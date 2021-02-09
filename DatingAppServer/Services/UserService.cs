using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models.DataModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatingAppServer.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> AddUserAsync(User newUser)
        {
            return await _userRepository.AddAsync(newUser);
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllUsersAsync();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _userRepository.GetUserByIdAsync(id);
        }

        public async Task<User> Login(User user)
        {
            return await _userRepository.GetUserByDetailsAsync(user);
        }

        public async Task<User> UpdateUserAsync(User updatedUser)
        {
            return await _userRepository.UpdateAsync(updatedUser);
        }

        public async Task<User> DeleteUserAsync(int id)
        {
            return await _userRepository.DeleteAsync(id);
        }
    }
}
