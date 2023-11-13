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

namespace Conversation.RequestHandler.MessageHandler
{
    public class MessageHandler:IMessageHandler
    {
        public IConfiguration configuration { get; }
        private readonly IHttpHandler httpHandler;
        public MessageHandler(IConfiguration configurations, IHttpHandler httpHandler)
        {
            this.configuration = configurations;
            this.httpHandler = httpHandler;
        }
        public async Task<List<MessageListEntity>> GetMessagesList()
        {
            try
            {
                string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
                string uri = configuration.GetValue<string>(MessageConstants.uri)+ configuration.GetValue<string>(MessageConstants.AccountSid);
                var apiUrl = uri+ MessageConstants.Messages+MessageConstants.Json;
                MessageListRsponce list =await  httpHandler.GetRequest<MessageListRsponce>(apiUrl, AccessToken);

                return list.messages;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<MessageListEntity> GetMessageBySid(string messageSid)
        {
            try
            {
                string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
                string uri = configuration.GetValue<string>(MessageConstants.uri)+ configuration.GetValue<string>(MessageConstants.AccountSid) ;
                var apiUrl = uri+ MessageConstants.Messages+"/"+ messageSid + MessageConstants.Json;
                MessageListEntity messageEntity =await  httpHandler.GetRequest<MessageListEntity>(apiUrl, AccessToken);

                return messageEntity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<MessageListEntity> CreateMessage(CreateMessageTIn createMessage)
        {
            try
            {
                string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
                string uri = configuration.GetValue<string>(MessageConstants.uri)+ configuration.GetValue<string>(MessageConstants.AccountSid) ;
                var apiUrl = uri+ MessageConstants.Messages + MessageConstants.Json;

                var json = JsonConvert.SerializeObject(createMessage);
                var Tin = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                MessageListEntity messageEntity = await httpHandler.PostRequestForAllCreations<Dictionary<string, string>, MessageListEntity>(apiUrl, Tin, AccessToken);

                return messageEntity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<MessageListEntity> ModifyMessage(ModifyMessage modifyMessage)
        {
            try
            {
                modifyMessageBody modifyMessageBody = new modifyMessageBody();
                modifyMessageBody.body = modifyMessage.body;
                string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
                string uri = configuration.GetValue<string>(MessageConstants.uri)+ configuration.GetValue<string>(MessageConstants.AccountSid) ;
                var apiUrl = uri+ MessageConstants.Messages + "/" + modifyMessage.messageSid + MessageConstants.Json;
                MessageListEntity messageEntity = await httpHandler.PostRequest<modifyMessageBody, MessageListEntity>(apiUrl, modifyMessageBody, AccessToken);

                return messageEntity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<string> DeleteMessage(string messageSid)
        {
            try
            {
                string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
                string uri = configuration.GetValue<string>(MessageConstants.uri)+ configuration.GetValue<string>(MessageConstants.AccountSid) ;
                var apiUrl = uri+ MessageConstants.Messages + "/" + messageSid + MessageConstants.Json;
                string list = await httpHandler.DeleteRequest<string>(apiUrl, AccessToken);

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
