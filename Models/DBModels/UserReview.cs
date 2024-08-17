using System.ComponentModel.DataAnnotations;

namespace library_backend.Models.DBModels
{
    public class UserReview
    {
        public int UserReviewId {  get; set; }

        public int UserBookId { get; set; }
        public int Rating { get; set; }
        [MaxLength(2000)]
        public string Review { get; set; } = string.Empty;

        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;

        public virtual UserBook UserBook { get; set; }
    }
}
