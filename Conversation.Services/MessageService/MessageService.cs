using Conversation.RequestHandler.MessageHandler;
using ConversationAPI.DataAccess.EntityPlatform;
using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.Services.MessageService
{
    public class MessageService:IMessageService
    {
        public readonly IMessageHandler messageHandler;
        private readonly IEntityHandler entityData;
        public MessageService(IMessageHandler _messageHandler, IEntityHandler entityData)
        {
            this.messageHandler = _messageHandler;
            this.entityData = entityData;
        }

        public List<MessageListEntity> MessagesList()
        {
            try
            {
                DataSet dataset = this.entityData.GetAllEntityCategory();
                return this.messageHandler.GetMessagesList().Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public MessageListEntity GetMessageBySid(string messageSid)
        {
            try
            {
                return this.messageHandler.GetMessageBySid(messageSid).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public MessageListEntity CreateMessage(CreateMessageTIn createMessage)
        {
            try
            {
                return this.messageHandler.CreateMessage(createMessage).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string DeleteMessage(string messageSid)
        {
            try
            {
                return this.messageHandler.DeleteMessage(messageSid).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public MessageListEntity ModifyMessage(ModifyMessage modifyMessage)
        {
            try
            {
                return this.messageHandler.ModifyMessage(modifyMessage).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
