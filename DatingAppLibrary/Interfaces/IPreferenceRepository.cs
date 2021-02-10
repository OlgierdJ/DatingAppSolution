using DatingAppLibrary.Models.DataModels;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface IPreferenceRepository : IRepository<Preference>
    {
        Task<Preference> GetPreferenceByIdAsync(int id);
    }
}
