using library_backend.Models.Enums;

namespace library_backend.Models.DBModels
{
    public class User
    {
        public int UserId { get; set; }
        public string Email { get; set; } = string.Empty;
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public bool IsArchived { get; set; } = false;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public EnumRole Role { get; set; } = EnumRole.customer;

        public DateTime? LastLoginDateTime { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;

        public virtual ICollection<UserBook> UserBooks { get; set; } = new HashSet<UserBook>();




    }
}
