using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.Services.MessageService
{
    public interface IMessageService
    {
        public List<MessageListEntity> MessagesList();
        public MessageListEntity GetMessageBySid(string messageSid);
        public MessageListEntity CreateMessage(CreateMessageTIn createMessage);
        public MessageListEntity ModifyMessage(ModifyMessage modifyMessage);
        public string DeleteMessage(string messageSid);
    }
}
