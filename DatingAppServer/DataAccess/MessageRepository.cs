using DatingAppLibrary.Interfaces;
using DatingAppLibrary.Models.DataModels;
using DatingAppServer.DBConnection;
using System;
using System.Threading.Tasks;

namespace DatingAppServer.DataAccess
{
    public class MessageRepository : Repository<Message>, IMessageRepository
    {
        public MessageRepository(DBDataContext context) : base(context)
        {
        }
        public Task<Message> GetMessageByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
