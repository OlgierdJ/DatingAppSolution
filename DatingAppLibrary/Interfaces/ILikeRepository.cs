using DatingAppLibrary.Models.DataModels;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface ILikeRepository : IRepository<Like>
    {
        Task<Like> GetLikeByIdAsync(int id);
    }
}
