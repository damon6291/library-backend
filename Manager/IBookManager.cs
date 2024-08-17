using library_backend.Mapper;
using library_backend.Models;
using library_backend.Models.Book;
using library_backend.Models.DBModels;
using library_backend.Models.Enums;

namespace library_backend.Manager
{
    public interface IBookManager
    {
        public Task<(int, List<Book>)> GetBooks(Page page);

        public Task<(int, List<UserBook>)> GetUserBooks(int userId, Page page);

        public Task<Book?> GetBook(int bookId);
        public Task<(int, List<UserReview>)> GetReviews(int bookId, Page page);

        public Task<(bool, object)> WriteReview(ReviewDTO review);

        public Task<(bool, string)> RentBook(int bookId, int userId);

        public Task<(bool, string)> ReturnBook(int bookId);

        public Task<(bool, int)> RemoveBook(int bookId);

        public Task<(bool, object)> UpsertBook(BookDTO dto);

        public Task FindLateBooks();
    }
}
