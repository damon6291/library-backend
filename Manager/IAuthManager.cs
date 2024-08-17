using library_backend.Mapper;
using library_backend.Models.Auth;
using library_backend.Models.DBModels;
using library_backend.Services;

namespace library_backend.Manager
{
    public interface IAuthManager
    {
        public Task<User?> GetUser(int userId);

        public Task<User?> GetActiveUserByEmail(string email);

        public Task<(bool, object)> Login(LoginDTO dto);

        public Task<(bool, string)> Register(UserDTO dto);


        public Task<(bool, string)> Refresh(int userId);
    }
}
