﻿using ConvertionEntities.Entities;
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
        Task<ChatEntity> CreateFirstConversation(ChatFriendlyName friendlyName);
        Task<ChatEntity> FetchConversation(string ConversationSid);
        Task<Conversations> GetAllConversations();
        Task<MessageEntity> GetMessagesByConversationId(string ConversationId);
        Task<SendNotificationByIdentity> SendNotificationByIdentity(NotificationsBody msgBody);


    }
}