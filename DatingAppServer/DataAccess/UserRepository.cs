using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models.DataModels;
using DatingAppServer.DBConnection;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingAppServer.DataAccess
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DBDataContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await GetAll().ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await 
                GetAll()
                .Include(e => e.UserProfile).ThenInclude(e => e.Preferences).ThenInclude(e => e.SexPrefs)
                .Include(e => e.PeopleWhoILike)
                .Include(e => e.PeopleWhoLikesMe)
                .FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<User> GetUserByDetailsAsync(User attempt)
        {
            return await GetAll()
                .Include(e => e.UserProfile).ThenInclude(e=>e.Preferences).ThenInclude(e=>e.SexPrefs)
                .Include(e=>e.PeopleWhoILike)
                .Include(e=>e.PeopleWhoLikesMe)
                .FirstOrDefaultAsync(x => x.Username == attempt.Username && x.Password == attempt.Password);
            //return await GetAll().FirstOrDefaultAsync(x => x.Username == attempt.Username && x.Password == attempt.Password);
        }

        public async Task<User> DeleteAsync(int id)
        {
           return await DeleteAsync(await GetUserByIdAsync(id));
        }
        //    public Task<User> GetAsync(int ObjectID)
        //    {
        //        throw new NotImplementedException();
        //    }
    }
}
