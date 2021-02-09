﻿using DatingAppLibrary.Models;
using DatingAppLibrary.Models.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface IPreferenceRepository : IRepository<Preference>
    {
        Task<Preference> GetPreferenceByIdAsync(int id);
    }
}
