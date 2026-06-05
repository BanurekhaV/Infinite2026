using Microsoft.AspNetCore.Mvc;
using DTO_Prj.Mappers;
using DTO_Prj.Models;
using AutoMapper;
using DTO_Prj.DTO;


namespace DTO_Prj.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }
        private static List<User> _users = new List<User>
        {
            new User{Id= 1, FullName= "Ben Johnson", Email="Ben@example.com",Password ="$A#b1", CreatedDate=DateTime.Now},
            new User{Id= 2, FullName= "Maria Smith", Email="smith@example.com",Password ="secret_h$2"}
        };
        public IActionResult Index()
        {
            //manual mapper
            //var userDtos = _users.Select(user => UserMapper.MaptoDTO(user)).ToList();

            //auto mapper
            var userDtos = _mapper.Map<List<UserResponseDTO>>(_users);
            return View(userDtos);
        }
    }
}
