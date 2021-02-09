using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models;
using DatingAppLibrary.Models.DataModels;
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
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService userService)
        {
            _profileService = userService;
        }



        public async Task<ActionResult<Profile>> CreateProfile(Profile profile)
        {
            return await _profileService.AddProfileAsync(profile);
        }

        public async Task<ActionResult<List<Profile>>> GetAllProfiles()
        {
            return await _profileService.GetAllProfilesAsync();
        }

        public async Task<ActionResult<Profile>> GetProfileById(int id)
        {
            return await _profileService.GetProfileByIdAsync(id);
        }

        public async Task<ActionResult<Profile>> UpdateProfile(Profile updatedProfile)
        {
            return await _profileService.UpdateProfileAsync(updatedProfile);
        }

        public async Task<ActionResult<Profile>> DeleteProfile(Profile deletedProfile)
        {
            return await _profileService.DeleteProfileAsync(deletedProfile);
        }

    }
}
