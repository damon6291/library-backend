using library_backend.Models.Enums;

namespace library_backend.Models.DBModels
{
    public class UserBook
    {
        public int UserBookId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
        public DateTime RentalDate { get; set; } = DateTime.UtcNow;
        public int RentDays { get; set; } = 5;
        public EnumRentStatus Status { get; set; } = EnumRentStatus.borrowed;
        public bool HasReview { get; set; } = false;



        public virtual User User { get; set; }
        public virtual Book Book { get; set; }
        public virtual ICollection<UserReview> UserReviews { get; set; } = new HashSet<UserReview>();
    }
}
