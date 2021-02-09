using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models.DataModels;
using DatingAppServer.DBConnection;
using System.Threading.Tasks;

namespace DatingAppServer.DataAccess
{
    public class LikeRepository : Repository<Like>, ILikeRepository
    {
        public LikeRepository(DBDataContext context) : base(context)
        {
        }

        public Task<Like> GetLikeByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}
