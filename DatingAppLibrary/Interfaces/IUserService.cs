using DatingAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface IUserService
    {
        Task<User> AddUserAsync(User newCustomer);
        Task<List<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(int id);
        Task<User> UpdateUserAsync(User newCustomer);
        Task<User> DeleteUserAsync(User deletedUser);

    }
}
