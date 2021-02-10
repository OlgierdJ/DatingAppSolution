using System.Linq;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class, new()
    {
        Task<TEntity> AddAsync(TEntity entity);
        IQueryable<TEntity> GetAll();
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> DeleteAsync(TEntity objectID);
    }
}
