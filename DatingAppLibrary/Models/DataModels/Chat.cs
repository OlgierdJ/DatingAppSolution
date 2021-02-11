using System.Collections.Generic;

namespace DatingAppLibrary.Models.DataModels
{
    public class Chat
    {
        public int ID { get; set; }
        public List<Message> Messages { get; set; }
        public List<User> Participants { get; set; }
        public ChatMap Map { get; set; }
    }
}
