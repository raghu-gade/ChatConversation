using ConvertionEntities.Constants;
using ConvertionEntities.Entities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RequestHandler;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.RequestHandler.ParticipantHandler
{
    public class ParticipantHandler:IParticipantHandler
    {
        public IConfiguration configuration { get; }
        private readonly IHttpHandler httpHandler;
        public ParticipantHandler(IConfiguration configurations, IHttpHandler httpHandler)
        {
            this.configuration = configurations;
            this.httpHandler = httpHandler;
        }
        public async Task<AddParticipateToConversation> AddParticipant(UserEntity msgAddress, string MessageSid)
        {
            string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
            string uri = configuration.GetValue<string>(MessageConstants.ConversationUrl);
            var apiUrl = uri + MessageConstants.Conversations + "/" + MessageSid + "/" + MessageConstants.Participants;

            
            Dictionary<string, string> Tin1 = new Dictionary<string, string>()
            {
                { "Identity", msgAddress.Identity}
            };
            var json = JsonConvert.SerializeObject(Tin1);
            //var Tin = JsonConvert.DeserializeObject<Dictionary<string, string>;


            AddParticipateToConversation chatEntity = await httpHandler.PostRequest<Dictionary<string, string>, AddParticipateToConversation>(apiUrl, Tin1, AccessToken);

            return chatEntity;
        }
    }
}
