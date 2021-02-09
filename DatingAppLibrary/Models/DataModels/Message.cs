using System;
using System.Collections.Generic;
using System.Text;

namespace DatingAppLibrary.Models.DataModels
{
    public class Message
    {
        public int ID { get; set; }
        public DateTime TimeSent { get; set; }
        public string Content { get; set; }
        public int UserRefID { get; set; }
        public int ChatRefID { get; set; }
        public User Sender { get; set; }
        public Chat Chat { get; set; }
    }
}
