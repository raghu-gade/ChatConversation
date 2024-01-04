using Conversation.RequestHandler.ChatHandler;
using Conversation.RequestHandler.MessageHandler;
using Conversation.Services.MessageService;
using ConversationAPI.DataAccess.EntityPlatform;
using ConvertionEntities.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.Services.Chat
{
    public class ChatService : IChatService
    {
        public readonly IChatHandler chatHandler;
        private readonly IEntityHandler entityData;
        public ChatService(IChatHandler _chatHandler)
        {
            this.chatHandler = _chatHandler;
            //this.entityData = entityData;
        }
        public string CreateChatAccessToken(string name)
        {
            try
            {
                return this.chatHandler.CreateChatAccessToken(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string CreateVideoAccessToken(string name)
        {
            try
            {
                return this.chatHandler.CreateVideoAccessToken(name);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string CreateVideoTokenWithRoom(string name, string room)
        {
            try
            {
                return this.chatHandler.CreateVideoTokenWithRoom(name, room);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<RoomDetails> GetRooms()
        {
            try
            {

                return this.chatHandler.GetRooms().Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public ChatEntity CreateFirstConversation(ChatFriendlyName friendlyName)
        {
            try
            {
                return this.chatHandler.CreateFirstConversation(friendlyName).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ChatEntity FetchConversation(string ConversationSid)
        {
            try
            {
                return this.chatHandler.FetchConversation(ConversationSid).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Conversations GetAllConversations()
        {
            try
            {
                return this.chatHandler.GetAllConversations().Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public MessageEntity GetMessagesByConversationId(string ConversationId)
        {
            try
            {
                return this.chatHandler.GetMessagesByConversationId(ConversationId).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ConversationParticipant GetParticipantsByConversationSid(string ConversationId)
        {
            try
            {
                return this.chatHandler.GetParticipantsByConversationSid(ConversationId).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public SendNotificationByIdentity SendNotificationByIdentity(NotificationsBody msgBody)
        {
            try
            {
                return this.chatHandler.SendNotificationByIdentity(msgBody).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
