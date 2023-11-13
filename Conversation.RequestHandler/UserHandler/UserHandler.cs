using ConvertionEntities.Constants;
using ConvertionEntities.Entities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RequestHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio.TwiML.Voice;

namespace Conversation.RequestHandler.UserHandler
{
    public class UserHandler:IUserHandler
    {
        public IConfiguration configuration { get; }
        private readonly IHttpHandler httpHandler;
        public UserHandler(IConfiguration configurations, IHttpHandler httpHandler)
        {
            this.configuration = configurations;
            this.httpHandler = httpHandler;
        }
        public async Task<UserCreationResponse> CreateNewUser(UserEntity identity)
        {
            string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
            string uri = configuration.GetValue<string>(MessageConstants.ConversationUrl);
            var apiUrl = uri + MessageConstants.Users;



            //var json = JsonConvert.SerializeObject(identity);
            //var Tin = JsonConvert.DeserializeObject<UserEntity>(json);


            UserCreationResponse chatEntity = await httpHandler.PostRequest<UserEntity, UserCreationResponse>(apiUrl, identity, AccessToken);

            return chatEntity;
        }
        public async Task<UserCreationResponse> GetUserById(string id)
        {
            string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
            string uri = configuration.GetValue<string>(MessageConstants.ConversationUrl);
            var apiUrl = uri + MessageConstants.Users+"/"+id;        
            
            UserCreationResponse chatEntity = await httpHandler.GetRequest<UserCreationResponse>(apiUrl, AccessToken);

            return chatEntity;
        }
        public async Task<GetUserList> GetUsers()
        {
            string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
            string uri = configuration.GetValue<string>(MessageConstants.ConversationUrl);
            var apiUrl = uri + MessageConstants.Users;

            GetUserList chatEntity = await httpHandler.GetRequest<GetUserList>(apiUrl, AccessToken);

            return chatEntity;
        }
        public async Task<UserCreationResponse> UpdateUser(UpdateUserEntity user, string id)
        {
            string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
            string uri = configuration.GetValue<string>(MessageConstants.ConversationUrl);
            var apiUrl = uri + MessageConstants.Users + '/'+id;

            var json = JsonConvert.SerializeObject(user);
            var Tin = JsonConvert.DeserializeObject<UpdateUserEntity>(json);

            UserCreationResponse chatEntity = await httpHandler.PostRequest<UpdateUserEntity, UserCreationResponse>(apiUrl, Tin, AccessToken);

            return chatEntity;
        }
    }
}
