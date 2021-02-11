using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models.DataModels;
using DatingAppServer.DBConnection;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingAppServer.DataAccess
{
    public class ProfileRepository : Repository<Profile>, IProfileRepository
    {
        public ProfileRepository(DBDataContext context) : base(context)
        {
        }

        public async Task<Profile> DeleteAsync(int id)
        {
            //bad practice but i dont really feel like setting up anything for delete by id when it should be an admin only call
            return await DeleteAsync(await GetProfileByIdAsync(id));
        }

        public async Task<List<Profile>> GetAllProfilesAsync()
        {
            return await GetAll().Include(e => e.Preferences).ThenInclude(e => e.SexPrefs).ToListAsync();
        }

        public async Task<Profile> GetProfileByIdAsync(int id)
        {
            return await GetAll().Include(e => e.Preferences).ThenInclude(e => e.SexPrefs).FirstOrDefaultAsync(x => x.ID == id);
        }
    }
}
