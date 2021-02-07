using System;
using System.Collections.Generic;
using System.Text;

namespace DatingAppLibrary.Models
{
    /// <summary>
    /// Object used for storing preference details.
    /// </summary>
    public class Preference
    {
        /// <summary>
        /// Integer unique ID.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// ID referencing parent profile object.
        /// </summary>
        public int ProfileRefID { get; set; }
        /// <summary>
        /// Navigational Profile object list containing users profile details.
        /// </summary>
        public Profile Profile { get; set; }
        /// <summary>
        /// Navigational SexualPreference object list containing sexual preferences.
        /// </summary>
        public ICollection<SexualPreference> SexPrefs { get; set; }
        /// <summary>
        /// Minimum age range in years.
        /// </summary>
        public int MinAge { get; set; }
        /// <summary>
        /// Maximum age range in years.
        /// </summary>
        public int MaxAge { get; set; }
    }
}
