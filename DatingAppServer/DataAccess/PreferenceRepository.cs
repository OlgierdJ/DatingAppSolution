using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models.DataModels;
using DatingAppServer.DBConnection;
using System;
using System.Threading.Tasks;

namespace DatingAppServer.DataAccess
{
    public class PreferenceRepository : Repository<Preference>, IPreferenceRepository
    {
        public PreferenceRepository(DBDataContext context) : base(context)
        {
        }

        public Task<Preference> GetPreferenceByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
