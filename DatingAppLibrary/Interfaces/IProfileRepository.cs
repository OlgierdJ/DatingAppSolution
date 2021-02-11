using DatingAppLibrary.Models.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface IProfileRepository : IRepository<Profile>
    {
        Task<Profile> GetProfileByIdAsync(int id);
        Task<Profile> DeleteAsync(int id);
        Task<List<Profile>> GetAllProfilesAsync();
    }
}
