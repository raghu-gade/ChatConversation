using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.Services.Chat
{
    public interface IChatService
    {
        public string CreateChatAccessToken(string name);
        public ChatEntity CreateFirstConversation(ChatFriendlyName friendlyName);
        public ChatEntity FetchConversation(string MessageSid);
        public Conversations GetAllConversations();
        public MessageEntity GetMessagesByConversationId(string ConversationId);
        public SendNotificationByIdentity SendNotificationByIdentity(NotificationsBody msgBody);
        public string CreateVideoAccessToken(string name);
        public string CreateVideoTokenWithRoom(string name, string room);
        public IEnumerable<RoomDetails> GetRooms();





    }
}
