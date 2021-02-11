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
            return await GetAll()
                .Include(e => e.UserProfile).ThenInclude(e => e.Preferences).ThenInclude(e => e.SexPrefs)
                .Include(e => e.PeopleWhoILike)
                .Include(e => e.PeopleWhoLikesMe)
                .Include(e => e.Chats).ThenInclude(e => e.Messages).ToListAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await 
                GetAll()
               .Include(e => e.UserProfile).ThenInclude(e => e.Preferences).ThenInclude(e => e.SexPrefs)
                .Include(e => e.PeopleWhoILike)
                .Include(e => e.PeopleWhoLikesMe)
                .Include(e => e.Chats).ThenInclude(e => e.Messages)
                .FirstOrDefaultAsync(x => x.ID == id);
        }

        public async Task<User> GetUserByDetailsAsync(User attempt)
        {
            return await GetAll()
                .Include(e => e.UserProfile).ThenInclude(e=>e.Preferences).ThenInclude(e=>e.SexPrefs)
                .Include(e=>e.PeopleWhoILike)
                .Include(e=>e.PeopleWhoLikesMe)
                .Include(e=>e.Chats).ThenInclude(e=>e.Messages)
                .FirstOrDefaultAsync(x => x.Username == attempt.Username && x.Password == attempt.Password);
        }

        public async Task<User> DeleteAsync(int id)
        {
            //bad practice but i dont really feel like setting up anything for delete by id when it should be an admin only call
            return await DeleteAsync(await GetUserByIdAsync(id));
        }
    }
}
