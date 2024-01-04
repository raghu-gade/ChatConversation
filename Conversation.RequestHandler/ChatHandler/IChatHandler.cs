using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.RequestHandler.ChatHandler
{
    public interface IChatHandler
    {
        string CreateChatAccessToken(string name);
        string CreateVideoAccessToken(string name);
        string CreateVideoTokenWithRoom(string name, string room);
        Task<IEnumerable<RoomDetails>> GetRooms();
        Task<ChatEntity> CreateFirstConversation(ChatFriendlyName friendlyName);
        Task<ChatEntity> FetchConversation(string ConversationSid);
        Task<Conversations> GetAllConversations();
        Task<MessageEntity> GetMessagesByConversationId(string ConversationId);
        Task<ConversationParticipant> GetParticipantsByConversationSid(string ConversationSid);
        Task<SendNotificationByIdentity> SendNotificationByIdentity(NotificationsBody msgBody);


    }
}
