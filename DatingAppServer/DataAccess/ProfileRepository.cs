using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models.DataModels;
using DatingAppServer.DBConnection;
using Microsoft.EntityFrameworkCore;
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
