using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models.DataModels;
using DatingAppServer.DBConnection;
using System;
using System.Threading.Tasks;

namespace DatingAppServer.DataAccess
{
    public class SexualPreferenceRepository : Repository<SexualPreference>, ISexualPreferenceRepository
    {
        public SexualPreferenceRepository(DBDataContext context) : base(context)
        {
        }

        public Task<SexualPreference> GetSexualPreferenceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
