using DatingAppLibrary.Models.DataModels;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface ISexualPreferenceRepository : IRepository<SexualPreference>
    {
        Task<SexualPreference> GetSexualPreferenceByIdAsync(int id);
    }
}
