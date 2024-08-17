using library_backend.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace library_backend.Models.DBModels
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        [MaxLength(2000)]
        public string? Description { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public byte[]? Image { get; set; }
        public string Publisher { get ; set; } = string.Empty;
        public DateTime? PublicationDate { get; set; }
        public EnumBookCategory Category { get; set; }
        public string ISBN { get; set; } = string.Empty;
        public int? PageCount { get; set; }
        public int RatingTotal { get; set; } = 0;
        public int RatingCount { get; set; } = 0;
        public bool IsAvailable { get; set; } = true;
        public bool IsArchived { get; set; } = false;
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;

        public virtual ICollection<UserBook> UserBooks { get; set; } = new HashSet<UserBook>();
        public virtual ICollection<UserReview> UserReviews { get; set; } = new HashSet<UserReview>();
    }
}
