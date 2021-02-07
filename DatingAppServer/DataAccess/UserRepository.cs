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
    public class UserRepository :  Repository<User>, IUserRepository
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
    }
    //public class UserRepository : IUserService
    //{
    //    private DBDataContext _context;
    //    public UserRepository(DBDataContext context)
    //    {
    //        _context = context;
    //    }

    //    public User Add(User newObject)
    //    {
    //        _context.Users.Add(newObject);
    //        newObject.ID = _context.Users.Max(e => e.ID) + 1;
    //        return newObject;
    //    }

    //    public async Task<User> AddAsync(User newUser)
    //    {
    //        if (newUser == null)
    //        {
    //            throw new ArgumentNullException($"{nameof(AddAsync)} object is null");
    //        }
    //        try
    //        {
    //            await _context.AddAsync(newUser);
    //            await _context.SaveChangesAsync();
    //            return newUser;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception($"{nameof(newUser)} could not be saved: {ex.Message}");
    //        }
    //    }

    //    public IEnumerable<User> GetAll()
    //    {
    //        return _context.Users.ToList();
    //    }

    //    public Task<IEnumerable<User>> GetAllAsync()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public User Get(int ObjectID)
    //    {
    //        return _context.Users.FirstOrDefault(e => e.ID == ObjectID);
    //    }

    //    public User Update(User changedObject)
    //    {
    //        User user = _context.Users.FirstOrDefault(e => e.ID == changedObject.ID);
    //        if (user != null)
    //        {
    //            user.Email = changedObject.Email;
    //            user.Username = changedObject.Username;
    //            user.Password = changedObject.Password;
    //            user.UserProfile = changedObject.UserProfile;
    //            user.Active = changedObject.Active;
    //            user.Liked = changedObject.Liked;
    //            user.Likers = changedObject.Likers;
    //            _context.SaveChanges();
    //        }
    //        return user;
    //    }

    //    public User Delete(int ObjectID)
    //    {
    //        User deletedUser = _context.Users.FirstOrDefault(e => e.ID == ObjectID);
    //        if (deletedUser != null)
    //        {
    //            _context.Users.Remove(deletedUser);
    //        }
    //        return deletedUser;
    //    }

    //    public Task<User> GetAsync(int ObjectID)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public async Task<User> UpdateAsync(User updatedUser)
    //    {
    //        if (updatedUser == null)
    //        {
    //            throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
    //        }
    //        try
    //        {
    //            _context.Update(updatedUser);
    //            await _context.SaveChangesAsync();
    //            return updatedUser;
    //        }
    //        catch (Exception ex)
    //        {
    //            throw new Exception($"{nameof(updatedUser)} could not be updated: {ex.Message}");
    //        }
    //    }

    //    public Task<User> DeleteAsync(int objectID)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
