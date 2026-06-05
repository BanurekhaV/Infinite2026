using DTO_Prj.Models;
using DTO_Prj.DTO;
using AutoMapper;

namespace DTO_Prj.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            //telling the mapper to automatically match the properties of the User 
            //to the userResponseDTO
            CreateMap<User, UserResponseDTO>();
                
        }
    }
}
