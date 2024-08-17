using library_backend.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace library_backend.Models.Book
{
    public class BookDTO
    {
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public byte[]? Image { get; set; }
        public string Publisher { get; set; } = string.Empty;
        public DateTime? PublicationDate { get; set; }
        public string Category { get; set; }
        public string ISBN { get; set; } = string.Empty;
        public int? PageCount { get; set; }
        public double Rating { get; set; } = 0;
        public bool IsAvailable { get; set; } = true;
        public bool IsArchived { get; set; } = false;
        public int? UserBookId { get; set; }
        public bool? IsReviewed { get; set; } // This is for user book id
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;

        public DateTime? RentedDate { get; set; }
        public DateTime? ExpectedReturnDate { get; set; }
    }
}
