using library_backend.Models.DBModels;
using library_backend.Models.Auth;
using library_backend.Models.Enums;
using library_backend.Helper;

namespace library_backend.Mapper
{
    public static class UserMapper
    {
        public static UserDTO UserToDTO(User user)
        {
            return new UserDTO()
            {
                UserId = user.UserId,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                IsArchived = user.IsArchived,
                CreatedDateTime = user.CreatedDateTime,
                LastLoginDateTime = user.LastLoginDateTime,
                Role = user.Role.GetDescription()
            };
        }

        public static User DTOToUser(UserDTO dto)
        {
            var type = EnumExtension.GetValueFromDescription<EnumRole>(dto.Role);
            return new User()
            {
                Email = dto.Email,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Role = type,
            };
        }


    }
}
