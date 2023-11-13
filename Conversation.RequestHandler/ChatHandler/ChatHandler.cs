using ConvertionEntities.Constants;
using ConvertionEntities.Entities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RequestHandler;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.Jwt.AccessToken;

namespace Conversation.RequestHandler.ChatHandler
{
    public class ChatHandler : IChatHandler
    {
        public IConfiguration configuration { get; }
        private readonly IHttpHandler httpHandler;
        public ChatHandler(IConfiguration configurations, IHttpHandler httpHandler)
        {
            this.configuration = configurations;
            this.httpHandler = httpHandler;
        }

        public async Task<ChatEntity> CreateFirstConversation(ChatFriendlyName friendlyName)
        {
            string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
            string uri = configuration.GetValue<string>(MessageConstants.ConversationUrl);
            var apiUrl = uri + MessageConstants.Conversations;

            var json = JsonConvert.SerializeObject(friendlyName);
            var Tin = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);


            ChatEntity chatEntity = await httpHandler.PostRequest<Dictionary<string, string>, ChatEntity>(apiUrl, Tin, AccessToken);

            return chatEntity;
        }

        public async Task<ChatEntity> FetchConversation(string ConversationSid)
        {
            string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
            string uri = configuration.GetValue<string>(MessageConstants.ConversationUrl);
            var apiUrl = uri + MessageConstants.Conversations + "/" + ConversationSid;
            ChatEntity chatEntity = await httpHandler.GetRequest<ChatEntity>(apiUrl, AccessToken);
            return chatEntity;
        }

        public async Task<Conversations> GetAllConversations()
        {
            string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
            string uri = configuration.GetValue<string>(MessageConstants.ConversationUrl);
            var apiUrl = uri + MessageConstants.Conversations;
            Conversations chatEntity = await httpHandler.GetRequest<Conversations>(apiUrl, AccessToken);
            return chatEntity;
        }
        public async Task<MessageEntity> GetMessagesByConversationId(string ConversationId)
        {
            string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
            string uri = configuration.GetValue<string>(MessageConstants.ConversationUrl);
            var apiUrl = uri + MessageConstants.Conversations + "/" + ConversationId + MessageConstants.Messages;
            MessageEntity chatEntity = await httpHandler.GetRequest<MessageEntity>(apiUrl, AccessToken);
            return chatEntity;

        }

        //SEND NOTIFIACTION BY IDENTITY
        public async Task<SendNotificationByIdentity> SendNotificationByIdentity(NotificationsBody msgBody)
        {
            string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
            string uri = configuration.GetValue<string>(MessageConstants.NotificationUrl);
            var apiUrl = uri + configuration.GetValue<string>(MessageConstants.pushConfigSid) + "/Notifications";

            var json = JsonConvert.SerializeObject(msgBody);
            var Tin = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

            SendNotificationByIdentity chatEntity = await httpHandler.PostRequestForAllCreations<Dictionary<string, string>, SendNotificationByIdentity>(apiUrl, Tin, AccessToken);
            return chatEntity;

        }

        public string CreateChatAccessToken(string name)
        {
            try
            {
                // These values are necessary for any access token
                // To set up environmental variables, see http://twil.io/secure
                string twilioAccountSid = configuration.GetValue<string>(MessageConstants.AccountSid);
                string twilioApiKey = configuration.GetValue<string>(MessageConstants.ApiSid);
                string twilioApiSecret = configuration.GetValue<string>(MessageConstants.SecretKey);
                string pushCredentialSid = configuration.GetValue<string>(MessageConstants.pushConfigSid);
                // These are specific to Chat
                string serviceSid = configuration.GetValue<string>(MessageConstants.ServiceSid);
                string identity = name;
                // Create an Chat grant for this token

                var grant = new ChatGrant
                {
                    ServiceSid = serviceSid,
                    PushCredentialSid = pushCredentialSid
                };

                var grants = new HashSet<IGrant>
                {
                    { grant }
                };

                // Create an Access Token generator
                var token = new Token(
                    twilioAccountSid,
                    twilioApiKey,
                    twilioApiSecret,
                    identity,
                    grants: grants);

                //Console.WriteLine(token.ToJwt());

                return token.ToJwt();
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
                // These values are necessary for any access token
                // To set up environmental variables, see http://twil.io/secure

                string twilioAccountSid = configuration.GetValue<string>(MessageConstants.AccountSid);
                string twilioApiKey = configuration.GetValue<string>(MessageConstants.ApiSid);
                string twilioApiSecret = configuration.GetValue<string>(MessageConstants.SecretKey);

                // These are specific to Video
                string identity = name;

                // Create a Video grant for this token
                var grant = new VideoGrant();
                //grant.Room = chatRoom;

                var grants = new HashSet<IGrant> { grant };

                // Create an Access Token generator
                var token = new Token(
                    twilioAccountSid,
                    twilioApiKey,
                    twilioApiSecret,
                    identity: identity,
                    grants: grants);

                Console.WriteLine(token.ToJwt());

                return token.ToJwt();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}