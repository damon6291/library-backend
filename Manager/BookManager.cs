using library_backend.Data;
using library_backend.Mapper;
using library_backend.Models;
using library_backend.Models.Book;
using library_backend.Models.DBModels;
using library_backend.Models.Enums;
using library_backend.Services;
using Microsoft.EntityFrameworkCore;

namespace library_backend.Manager
{
    public class BookManager : IBookManager
    {
        private readonly LibraryDbContext context;
        private readonly IUserService userService;

        public BookManager(LibraryDbContext context, IUserService userService)
        {
            this.context = context;
            this.userService = userService;
        }

        public async Task<(int, List<Book>)> GetBooks(Page page)
        {
            var activeBooks = context.Book.Include(x => x.UserBooks).Where(x => !x.IsArchived);
            return await page.Get(activeBooks);
        }


        public async Task<(int, List<UserBook>)> GetUserBooks(int userId, Page page)
        {
            var rentedBooks = context.UserBook.Include(x => x.Book).Where(x => x.UserId == userId && (x.Status == EnumRentStatus.borrowed || x.Status == EnumRentStatus.late));
            return await page.Get(rentedBooks);
        }

        public async Task<Book?> GetBook(int bookId)
        {
            var ret = await context.Book.FirstOrDefaultAsync(x => x.BookId == bookId);
            return ret;
        }

        public async Task<(int, List<UserReview>)> GetReviews(int bookId, Page page)
        {
            page.OrderColumn = "CreatedDateTime";
            page.IsAscending = false;

            var reviews = context.UserReview.Include(x => x.UserBook).Where(x => x.UserBook.BookId == bookId);
            return await page.Get(reviews);
        }

        public async Task<(bool, object)> WriteReview(ReviewDTO review)
        {
            var userReview = BookMapper.DTOToReview(review);
            context.Add(userReview);
            var userBook = await context.UserBook.Include(x => x.Book).Where(x => x.UserBookId == review.UserBookId).FirstOrDefaultAsync();
            if (userBook == null) return (false, "User didn't borrow this book");
            var book = userBook.Book;
            userBook.HasReview = true;
            book.RatingTotal += review.Rating;
            book.RatingCount += 1;
            await context.SaveChangesAsync();
            return (true, userReview.UserReviewId);
        }

        public async Task<(bool, string)> RentBook(int bookId, int userId)
        {
            var book = await GetBook(bookId);
            if (!book.IsAvailable) return (false, "Someone already rented this book");
            book.IsAvailable = false;
            UserBook ub = new();
            ub.UserId = userId;
            ub.BookId = bookId;
            context.Add(ub);
            await context.SaveChangesAsync();
            return (true, "Success");
        }

        public async Task<(bool, string)> ReturnBook(int bookId)
        {
            var book = await GetBook(bookId);
            book.IsAvailable = true;
            var ub = await context.UserBook.Where(x => x.BookId == bookId && x.Status != EnumRentStatus.returned).FirstOrDefaultAsync();
            ub.Status = EnumRentStatus.returned;
            await context.SaveChangesAsync();
            return (true, "Success");
        }


        public async Task<(bool, object)> UpsertBook(BookDTO dto)
        {
            var list = new List<Book>();
            var book = BookMapper.DTOToBook(dto);
            list.Add(book);
            await context.BulkMergeAsync(list, options =>
            {
                options.IgnoreOnMergeUpdateExpression = book => new
                {
                    book.RatingCount,
                    book.RatingTotal,
                    book.IsAvailable,
                    book.CreatedDateTime
                };
                
            });
            return (true, book.BookId);
        }

        public async Task<(bool, int)> RemoveBook(int bookId)
        {
            var book = await GetBook(bookId);
            book.IsArchived = true;
            await context.SaveChangesAsync();
            return (true, book.BookId);
        }

        public async Task FindLateBooks()
        {
            var date = DateTime.Now.AddDays(-5);
            await context.UserBook.Where(x => x.Status == EnumRentStatus.borrowed && x.RentalDate < date).UpdateFromQueryAsync(x => new UserBook { Status = EnumRentStatus.late });
        }


    }
}
