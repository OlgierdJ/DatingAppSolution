using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models;
using DatingAppServer.DBConnection;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppServer.Controllers
{
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }



        public async Task<ActionResult<User>> CreateUser(User user)
        {
            return await _userService.AddUserAsync(user);
        }

        public async Task<ActionResult<List<User>>> GetAllUsers()
        {
            return await _userService.GetAllUsersAsync();
        }

        public async Task<ActionResult<User>> GetUserById(int id)
        {
            return await _userService.GetUserByIdAsync(id);
        }
        public async Task<ActionResult<User>> UpdateUser(User user)
        {
            return await _userService.UpdateUserAsync(user);
        }

        public async Task<ActionResult<User>> DeleteUser(User deletedUser)
        {
            return await _userService.DeleteUserAsync(deletedUser);
        }

    }
}
