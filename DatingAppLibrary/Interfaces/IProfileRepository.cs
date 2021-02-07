using DatingAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface IProfileRepository : IRepository<Profile>
    {
        Task<Profile> GetProductByIdAsync(int id);
    }
}
