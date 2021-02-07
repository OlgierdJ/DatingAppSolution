using DatingAppLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface ISexualPreferenceRepository : IRepository<SexualPreference>
    {
        Task<SexualPreference> GetSexualPreferenceByIdAsync(int id);
    }
}
