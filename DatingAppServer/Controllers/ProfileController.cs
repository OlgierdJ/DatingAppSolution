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
    public class ProfileController : ControllerBase
    {
        private readonly IProfileService _profileService;

        public ProfileController(IProfileService profileService)
        {
            _profileService = profileService;
        }


        [HttpPost, Route("CreateProfile")]
        public async Task<ActionResult<Profile>> CreateProfile(Profile profile) => await _profileService.AddProfileAsync(profile);

        [HttpGet, Route("GetProfiles")]
        public async Task<ActionResult<List<Profile>>> GetAllProfiles() => await _profileService.GetAllProfilesAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Profile>> GetProfileById(int id) => await _profileService.GetProfileByIdAsync(id);

        [HttpPut("{id}")]
        public async Task<ActionResult<Profile>> UpdateProfile(Profile updatedProfile) => await _profileService.UpdateProfileAsync(updatedProfile);

        [HttpDelete("{id}")]
        public async Task<ActionResult<Profile>> DeleteProfile(Profile deletedProfile) => await _profileService.DeleteProfileAsync(deletedProfile);
    }
}
