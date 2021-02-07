using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models;
using DatingAppServer.DBConnection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            return await GetAll().FirstOrDefaultAsync(x => x.ID == id);
        }

        //    public Task<User> GetAsync(int ObjectID)
        //    {
        //        throw new NotImplementedException();
        //    }
    }
}
