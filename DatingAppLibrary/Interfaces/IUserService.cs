using DatingAppLibrary.Models.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface IUserService
    {
        Task<User> Login(User user);
        Task<User> AddUserAsync(User newUser);
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> UpdateUserAsync(User updatedUser);
        Task<User> DeleteUserAsync(int id);

    }
}
