﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatingAppLibrary.Models
{
    /// <summary>
    /// User object used for storing Email, Username, Password and UserProfileRefID
    /// </summary>
    public class User
    {
        /// <summary>
        /// Integer unique ID.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Email as string.
        /// </summary>
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        /// <summary>
        /// Username as string.
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// Password as string.
        /// </summary>
        [DataType(DataType.Password)]
        public string Password { get; set; }
        /// <summary>
        /// Navigational Profile object containing users details.
        /// </summary>
        public Profile UserProfile { get; set; }
        /// <summary>
        /// Boolean determining whether the user is Active or not.
        /// </summary>
        public bool Active { get; set; }
        /// <summary>
        /// DateTime holding the DoT of the creation of the User.
        /// </summary>
        public DateTime CreationDate { get; set; }
        /// <summary>
        /// Navigational List of Like objects containing the outgoing likes of the current user.
        /// </summary>
        public ICollection<Like> Liked { get; set; }
        /// <summary>
        /// Navigational List of Like objects containing the incoming likes of the current user.
        /// </summary>
        public ICollection<Like> Likers { get; set; }
        /// <summary>
        /// Matching property used for getting matching like objects.
        /// </summary>
        public ICollection<Like> matches
        {
            get
            {
                foreach (Like outgoing in Liked)
                {
                    foreach (Like incoming in Likers)
                    {
                        if (outgoing.Likee == incoming.Liker)
                        {
                            matches.Add(incoming);
                        }
                    }
                }
                return matches;
            }
        }
    }
}
