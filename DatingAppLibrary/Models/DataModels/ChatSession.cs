namespace DatingAppLibrary.Models.DataModels
{
    public class ChatSession
    {
        public int ID { get; set; }
        public int ChatRefID { get; set; }
        public Chat Chat { get; set; }
        public int UserRefID { get; set; }
        public User User { get; set; }
    }
}
