using API.Models;
using API.Repository.Interfaces;
using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly IUsersRepository _usersRepository;
        public UsersController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository;   
        }

        [HttpGet("getAll")]
        public IActionResult GetAllUsers()
        {
            return Ok(_usersRepository.GetAll());
        }

        [HttpPost("addUser")]
        public IActionResult AddUser(UsersVM user)
        {
            if (user == null)
            {
                return BadRequest("Something went wrong");
            }
            else
            {
                return Ok(_usersRepository.AddUser(user));
            }
        }

        [HttpPut("updateUser")]
        public IActionResult UpdateUser(UsersVM user)
        {
            if (user == null)
            {
                return BadRequest("Something went wrong");
            }
            else
            {
                return Ok(_usersRepository.UpdateUser(user));
            }
        }
    }
}
