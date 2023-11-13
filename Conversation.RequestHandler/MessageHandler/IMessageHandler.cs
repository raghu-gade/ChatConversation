using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.RequestHandler.MessageHandler
{
    public interface IMessageHandler
    {
        Task<List<MessageListEntity>> GetMessagesList();
        Task<MessageListEntity> GetMessageBySid(string messageSid);
        Task<MessageListEntity> CreateMessage(CreateMessageTIn createMessage);
        Task<MessageListEntity> ModifyMessage(ModifyMessage modifyMessage);
        Task<string>  DeleteMessage(string messageSid);
    }

}
