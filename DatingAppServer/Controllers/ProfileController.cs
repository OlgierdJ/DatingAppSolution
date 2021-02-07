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
    public class ProfileController : ControllerBase
    {
        private readonly IUserService _profileService;

        public ProfileController(IUserService userService)
        {
            _profileService = userService;
        }



        public async Task<ActionResult<Profile>> CreateProfile(Profile profile)
        {
            return await _profileService.AddUserAsync(profile);
        }

        public async Task<ActionResult<List<Profile>>> GetAllUsers()
        {
            return await _profileService.GetAllUsersAsync();
        }

        public async Task<ActionResult<Profile>> GetUserById(int id)
        {
            return await _profileService.GetUserByIdAsync(id);
        }

        public async Task<ActionResult<Profile>> UpdateUser(Profile updatedProfile)
        {
            return await _profileService.UpdateUserAsync(updatedProfile);
        }

        public async Task<ActionResult<Profile>> DeleteUser(Profile deletedProfile)
        {
            return await _profileService.DeleteProfileAsync(deletedProfile);
        }

    }
}
