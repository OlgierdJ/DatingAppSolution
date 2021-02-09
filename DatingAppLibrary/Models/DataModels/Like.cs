using DatingAppLibrary.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DatingAppLibrary.Models.DataModels
{
    /// <summary>
    /// Object used for holding outgoing and incoming likes.
    /// </summary>
    public class Like
    {
        /// <summary>
        /// Integer unique ID.
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// ID referencing the user who liked the other user.
        /// </summary>
        public int LikerRefID { get; set; }
        /// <summary>
        /// ID referencing the liked user.
        /// </summary>
        public int LikeeRefID { get; set; }
        /// <summary>
        /// Enum object used for 
        /// </summary>
        public LikeType LikeType { get; set; }
        /// <summary>
        /// DateTime holding the DoT of the creation of the Like.
        /// </summary>
        public DateTime DateOfLike { get; set; }
        /// <summary>
        /// Navigational object holding the user who liked the other user.
        /// </summary>
        public User Liker { get; set; }
        /// <summary>
        /// Navigational object holding the user who is liked.
        /// </summary>
        public User Likee { get; set; }
    }
}
