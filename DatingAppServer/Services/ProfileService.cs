using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppServer.Services
{
    public class ProfileService : IProfileService
    {
        private readonly IProfileRepository _profileRepository;

        public ProfileService(IProfileRepository profileRepository)
        {
            _profileRepository = profileRepository;
        }

        public async Task<Profile> AddProfileAsync(Profile newProfile)
        {
            return await _profileRepository.AddAsync(newProfile);
        }

        public async Task<Profile> DeleteProfileAsync(Profile deletedProfile)
        {
            return await _profileRepository.DeleteAsync(deletedProfile);
        }

        public async Task<List<Profile>> GetAllProfilesAsync() 
        {
            return await _profileRepository.GetAllProfilesAsync();
        }

        public async Task<Profile> GetProfileByIdAsync(int id)
        {
            return await _profileRepository.GetProfileByIdAsync(id);
        }

        public async Task<Profile> UpdateProfileAsync(Profile updatedProfile)
        {
            return await _profileRepository.UpdateAsync(updatedProfile);
        }
    }
}
