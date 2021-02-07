using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models;
using DatingAppServer.DBConnection;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingAppServer.DataAccess
{
    public class ProfileRepository : Repository<Profile>, IProfileRepository
    {
        public ProfileRepository(DBDataContext context) : base(context)
        {
        }

        public Task<Profile> GetProductByIdAsync(int id)
        {
            return GetAll().FirstOrDefaultAsync(x => x.ID == id);
        }
    }
}
