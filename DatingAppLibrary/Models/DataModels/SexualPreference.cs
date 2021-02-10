using DatingAppLibrary.Models.Enums;

namespace DatingAppLibrary.Models.DataModels
{
    /// <summary>
    /// Class used for binding many to many objects together via reference IDs.
    /// </summary>
    public class SexualPreference
    {
        /// <summary>
        /// Integer unique ID.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// ID referencing preference object.
        /// </summary>
        public int PreferenceRefID { get; set; }
        /// <summary>
        /// Navigational Preference object containing preferenced specifics.
        /// </summary>
        public Preference Preferences { get; set; }
        /// <summary>
        /// Navigational gender object containing preferenced gender.
        /// </summary>
        public Gender PreferencedGender { get; set; }

    }
}
