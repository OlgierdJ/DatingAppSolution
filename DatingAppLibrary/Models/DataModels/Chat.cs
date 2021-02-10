using System.Collections.Generic;

namespace DatingAppLibrary.Models.DataModels
{
    public class Chat
    {
        public int ID { get; set; }
        List<Message> Messages { get; set; }
        List<User> Participants { get; set; }
        public ChatSession Session { get; set; }
    }
}
