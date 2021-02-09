using DatingAppLibrary.Models.DataModels;
using System.Threading.Tasks;

namespace DatingAppLibrary.Interfaces
{
    public interface IMessageRepository : IRepository<Message>
    {
        Task<Message> GetMessageByIdAsync(int id);
    }
}
