using library_backend.Manager;
using library_backend.Managers;
using library_backend.Mapper;
using library_backend.Models;
using library_backend.Models.Book;
using library_backend.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace library_backend.Controllers
{
    [Route("api/book")]
    [ApiController]
    [Authorize]
    public class BookController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IAuthManager authManager;
        private readonly IBookManager bookManager;
        public BookController(IUserService userService, IAuthManager authManager, IBookManager bookManager)
        {
            this.userService = userService;
            this.authManager = authManager;
            this.bookManager = bookManager;
        }
        [HttpGet]
        public async Task<IActionResult> GetBooks([Required] int pageNumber, [Required] int pageSize, string orderColumn = "", bool isAscending = true, string title = "", string author = "", bool? availability = null)
        {
            var ret = new ReturnModel();
            var userId = userService.GetUserId();
            if (userId == null) return Ok(ret.Logout());
            Page page = new Page(pageNumber, pageSize, orderColumn, isAscending);
            List<Filter> filters = [new Filter("Title", Op.Contains, title), new Filter("Author", Op.Contains, author)];
            if (availability != null) filters.Add(new Filter("IsAvailable", Op.Equals, availability));
            page.Filters = filters;
            var (count, res) = await bookManager.GetBooks(page);
            List<BookDTO> dtos = new();
            foreach (var book in res)
            {
                dtos.Add(BookMapper.BookToDTO(book, book.UserBooks.Where(x => x.Status != Models.Enums.EnumRentStatus.returned).FirstOrDefault()));
            }
            ret.Success(new { count, books = dtos });
            return Ok(ret);
        }

        [HttpGet("{bookId}")]
        public async Task<IActionResult> GetBook(int bookId)
        {
            var ret = new ReturnModel();
            var userId = userService.GetUserId();
            if (userId == null) return Ok(ret.Logout());
            var res = await bookManager.GetBook(bookId);
            var book = BookMapper.BookToDTO(res, res.UserBooks.Where(x => x.Status != Models.Enums.EnumRentStatus.returned).FirstOrDefault());
            
            ret.Success(book);
            return Ok(ret);
        }

        [HttpGet("user")]
        public async Task<IActionResult> GetUserBooks([Required] int pageNumber, [Required] int pageSize)
        {
            var ret = new ReturnModel();
            var userId = userService.GetUserId();
            if (userId == null) return Ok(ret.Logout());
            Page page = new Page(pageNumber, pageSize, "RentalDate", false);
            var (count, res) = await bookManager.GetUserBooks(userId.Value, page);
            List<BookDTO> dtos = new();
            foreach (var userBook in res)
            {
                dtos.Add(BookMapper.BookToDTO(userBook.Book, userBook));
            }
            ret.Success(new { count, books = dtos });
            return Ok(ret);
        }

        [HttpGet("review/{bookId}")]
        public async Task<IActionResult> GetReviews([Required] int bookId, [Required] int pageNumber, [Required] int pageSize)
        {
            var ret = new ReturnModel();
            var userId = userService.GetUserId();
            if (userId == null) return Ok(ret.Logout());
            Page page = new Page(pageNumber, pageSize);
            var (count, res) = await bookManager.GetReviews(bookId, page);
            List<ReviewDTO> dtos = new();
            foreach (var review in res)
            {
                dtos.Add(BookMapper.ReviewToDTO(review));
            }
            ret.Success(new { count, reviews = dtos });
            return Ok(ret);
        }

        [HttpPost("review")]
        public async Task<IActionResult> PostReview(ReviewDTO dto)
        {
            var ret = new ReturnModel();
            var userId = userService.GetUserId();
            if (userId == null) return Ok(ret.Logout());
            var (res, obj) = await bookManager.WriteReview(dto);
            if (!res) return Ok(ret.Fail());
            ret.Success(obj);
            return Ok(ret);
        }

        [HttpPut("rent/{bookId}")]
        public async Task<IActionResult> RentBook(int bookId)
        {
            var ret = new ReturnModel();
            var userId = userService.GetUserId();
            if (userId == null) return Ok(ret.Logout());
            var (res, obj) = await bookManager.RentBook(bookId, userId.Value);
            if (!res) return Ok(ret.Fail(obj.ToString()));
            ret.Success(obj);
            return Ok(ret);
        }


        [HttpPut("return/{bookId}")]
        public async Task<IActionResult> ReturnBook(int bookId)
        {
            var ret = new ReturnModel();
            var userId = userService.GetUserId();
            if (userId == null) return Ok(ret.Logout());
            var (res, obj) = await bookManager.ReturnBook(bookId);
            if (!res) return Ok(ret.Fail(obj.ToString()));
            ret.Success(obj);
            return Ok(ret);
        }

        [HttpDelete("{bookId}")]
        public async Task<IActionResult> RemoveBook(int bookId)
        {
            var ret = new ReturnModel();
            var userId = userService.GetUserId();
            if (userId == null) return Ok(ret.Logout());
            var (res, obj) = await bookManager.RemoveBook(bookId);
            if (!res) return Ok(ret.Fail());
            ret.Success(obj);
            return Ok(ret);
        }

        [HttpPost("upsert")]
        public async Task<IActionResult> UpsertBook(BookDTO dto)
        {
            var ret = new ReturnModel();
            var userId = userService.GetUserId();
            if (userId == null) return Ok(ret.Logout());

            var (res, obj) = await bookManager.UpsertBook(dto);

            if (!res) return Ok(ret.Fail(obj.ToString()));

            return Ok(ret.Success(obj));
        }

    }
}
