using DatingAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface ILikeRepository : IRepository<Like>
    {
        Task<Like> GetLikeByIdAsync(int id);
    }
}
