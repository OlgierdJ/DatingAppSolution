using DatingAppLibrary.Models.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> GetUserByDetailsAsync(User attempt);
        Task<User> GetUserByIdAsync(int id);
        Task<User> DeleteAsync(int id);
        Task<List<User>> GetAllUsersAsync();
    }
}
