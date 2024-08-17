using library_backend.Helper;
using library_backend.Models.Book;
using library_backend.Models.DBModels;
using library_backend.Models.Enums;
using Microsoft.OpenApi.Extensions;

namespace library_backend.Mapper
{
    public static class BookMapper
    {
        public static ReviewDTO ReviewToDTO(UserReview review)
        {
            return new ReviewDTO
            {
                UserBookId = review.UserBookId,
                Review = review.Review,
                Rating = review.Rating,
                CreatedDateTime = review.CreatedDateTime,
            };
        }
        public static UserReview DTOToReview(ReviewDTO review)
        {
            return new UserReview
            {
                UserBookId = review.UserBookId,
                Review = review.Review,
                Rating = review.Rating,
            };
        }

        public static Book DTOToBook(BookDTO book)
        {
            var type = EnumExtension.GetValueFromDescription<EnumBookCategory>(book.Category);
            return new Book
            {
                BookId = book.BookId,
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                Image = book.Image,
                Publisher = book.Publisher,
                PublicationDate = book.PublicationDate,
                Category = type,
                ISBN = book.ISBN,
                PageCount = book.PageCount,
            };
        }
        public static BookDTO BookToDTO(Book book, UserBook? userBook)
        {
            return new BookDTO
            {
                BookId = book.BookId,
                Title = book.Title,
                Description = book.Description,
                Author = book.Author,
                Image = book.Image,
                Publisher = book.Publisher,
                PublicationDate = book.PublicationDate,
                Category = book.Category.GetDescription(),
                ISBN = book.ISBN,
                PageCount = book.PageCount,
                Rating = book.RatingCount == 0 ? 0 : (double)(book.RatingTotal / book.RatingCount),
                IsAvailable = book.IsAvailable,
                IsArchived = book.IsArchived,
                CreatedDateTime = book.CreatedDateTime,
                RentedDate = userBook?.RentalDate,
                ExpectedReturnDate = userBook?.RentalDate.AddDays(userBook.RentDays),
                UserBookId = userBook?.UserBookId,
                IsReviewed = userBook?.HasReview,
            };
        }
    }
}
