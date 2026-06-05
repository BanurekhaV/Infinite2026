using DTO_Prj.DTO;
using DTO_Prj.Models;

namespace DTO_Prj.Mappers
{
    public static class UserMapper
    {
        public static UserResponseDTO MaptoDTO(User user)
        {
            return new UserResponseDTO
            {
                Id = user.Id,
                FullName = user.FullName,
                Email = user.Email,
            };
        }
    }
}
