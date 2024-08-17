using library_backend.Data;
using library_backend.Helper;
using library_backend.Manager;
using library_backend.Mapper;
using library_backend.Models.Auth;
using library_backend.Models.DBModels;
using library_backend.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace library_backend.Managers
{
    public class AuthManager : IAuthManager
    {
        private readonly LibraryDbContext context;
        private readonly IUserService userService;

        public AuthManager(LibraryDbContext context, IUserService userService)
        {
            this.context = context;
            this.userService = userService;
        }

        public async Task<User?> GetUser(int userId)
        {
            var ret = await context.User.FirstOrDefaultAsync(x => x.UserId == userId);
            return ret;
        }

        public async Task<User?> GetActiveUserByEmail(string email)
        {
            var ret = await context.User.FirstOrDefaultAsync(x => x.Email == email && !x.IsArchived);
            return ret;
        }

        public async Task<(bool, object)> Login(LoginDTO dto) 
        {
            try
            {
                var user = await GetActiveUserByEmail(dto.Email);
                if (user == null) return (false, "Email does not exist");

                var verify = userService.VerifyPasswordHash(dto.Password, user.PasswordHash, user.PasswordSalt);
                if (!verify) return (false, "Password does not match");

                var token = userService.CreateToken(user.UserId, user.Role.ToString());
                user.LastLoginDateTime = DateTime.UtcNow;
                context.SaveChanges();

                return (true, new { token, role = user.Role.GetDescription() });
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, string)> Register(UserDTO dto)
        {
            try
            {
                var newUser = UserMapper.DTOToUser(dto);
                userService.CreatePasswordHash(dto.Password, out var passwordHash, out var passwordSalt);
                newUser.PasswordSalt = passwordSalt;
                newUser.PasswordHash = passwordHash;
                context.Add(newUser);
                await context.SaveChangesAsync();

                var token = userService.CreateToken(newUser.UserId, newUser.Role.GetDescription());

                return (true, string.Empty);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, string)> Refresh(int userId)
        {
            try
            {
                var user = await GetUser(userId);
                if (user == null) return (false, "User does not exist");

                var token = userService.CreateToken(user.UserId, user.Role.GetDescription());

                return (true, token);
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

    }
}
