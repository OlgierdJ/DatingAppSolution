using DatingAppLibrary.Models.DataModels;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface IProfileRepository : IRepository<Profile>
    {
        Task<Profile> GetProductByIdAsync(int id);
    }
}
