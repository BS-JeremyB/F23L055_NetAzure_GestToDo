using F23L055_GestToDo.Api.Dtos;
using F23L055_GestToDo.Api.Mappers;
using F23L055_GestToDo.Bll.Entities;
using F23L055_GestToDo.Bll.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace F23L055_GestToDo.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<GetUserDto> users = _userRepository.Get().Select(u => u.ToDto());
            return Ok(users);
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreeUserDto userDto)
        {
            if (!_userRepository.CreateUser(new User(userDto.Email, userDto.Password)))
            {
                return BadRequest();
            }

            return NoContent();
        }


        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginUserDto userDto)
        {
            string? token = _userRepository.Login(new User(userDto.Email, userDto.Password));
            if(token is null)
            {
                return BadRequest();
            }
            return Ok(token);
        }
    }
}
