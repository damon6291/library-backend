namespace library_backend.Services
{
    public interface IUserService
    {
        /// <summary>
        /// Get the user ID from http context
        /// </summary>
        /// <returns></returns>
        public int? GetUserId();
        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt);
        /// <summary>
        /// Create JWT Token Expiring in 12 hour
        /// </summary>
        public string CreateToken(int userId, string role);
    }
}
