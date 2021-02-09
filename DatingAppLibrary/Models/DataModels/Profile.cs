using DatingAppLibrary.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingAppLibrary.Models.DataModels
{
    /// <summary>
    /// Object used for storing user details aswell as reference ids.
    /// </summary>
    public class Profile
    {
        /// <summary>
        /// Integer unique ID.
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// ID referencing parent User object
        /// </summary>
        public int UserRefID { get; set; }

        /// <summary>
        /// First name as string.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Last name as string.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Age in years.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gender enum containing the specified gender of the user.
        /// </summary>
        public Gender Gender { get; set; }

        /// <summary>
        /// Navigational Preference object containing preferenced specifics.
        /// </summary>
        public Preference Preferences { get; set; }
        
        /// <summary>
        /// Navigational User object containing login credentials of the user the current profile belongs to.
        /// </summary>
        public User User { get; set; }

        /// <summary>
        /// Full name. (Get access concatonation)
        /// </summary>
        //[NotMapped]
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
    }
}
