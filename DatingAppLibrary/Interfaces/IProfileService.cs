using DatingAppLibrary.Models.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface IProfileService
    {
        Task<Profile> AddProfileAsync(Profile newProfile);
        Task<List<Profile>> GetAllProfilesAsync();
        Task<Profile> GetProfileByIdAsync(int id);
        Task<Profile> UpdateProfileAsync(Profile updatedProfile);
        Task<Profile> DeleteProfileAsync(Profile deletedProfile);

    }
}
