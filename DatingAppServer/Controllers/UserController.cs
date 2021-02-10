using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models.DataModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingAppServer.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost, Route("CreateUser")]
        public async Task<ActionResult<User>> CreateUser(User user) => await _userService.AddUserAsync(user);

        [HttpPost, Route("Login")]
        public async Task<ActionResult<User>> Login(User user)
        {
            User attempt = await _userService.Login(user);
            if (attempt==null)
            {
              return BadRequest();
            }
            return Ok(attempt);
        }

        [HttpGet, Route("GetUsers")]
        public async Task<ActionResult<List<User>>> GetAllUsers() => await _userService.GetAllUsersAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id) => await _userService.GetUserByIdAsync(id);

        [HttpPut("{id}")]
        public async Task<ActionResult<User>> UpdateUser(User user) => await _userService.UpdateUserAsync(user);

        [HttpDelete("{id}")]
        public async Task<ActionResult<User>> DeleteUser(int id) => await _userService.DeleteUserAsync(id);

    }
}
