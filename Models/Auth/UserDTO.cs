using library_backend.Models.Enums;

namespace library_backend.Models.Auth
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public bool IsArchived { get; set; } = false;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? LastLoginDateTime { get; set; }
        public DateTime? CreatedDateTime { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
    }
}
