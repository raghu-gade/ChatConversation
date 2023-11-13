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

namespace Conversation.RequestHandler.CallHandler
{
    public class CallHandler : ICallHandler
    {
        public IConfiguration configuration { get; }
        private readonly IHttpHandler httpHandler;
        public CallHandler(IConfiguration configurations, IHttpHandler httpHandler)
        {
            this.configuration = configurations;
            this.httpHandler = httpHandler;
        }
        public async Task<CallOutput> MakeACall(CallMaking callMaking)
        {
            try
            {
                string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
                string uri = configuration.GetValue<string>(MessageConstants.uri) + configuration.GetValue<string>(MessageConstants.AccountSid);
                var apiUrl = uri + MessageConstants.Calls + MessageConstants.Json;

                var json = JsonConvert.SerializeObject(callMaking);
                var Tin = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                CallOutput messageEntity = await httpHandler.PostRequestForAllCreations<Dictionary<string, string>, CallOutput>(apiUrl, Tin, AccessToken);

                return messageEntity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<CallOutput>> CallsList()
        {
            try
            {
                string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
                string uri = configuration.GetValue<string>(MessageConstants.uri) + configuration.GetValue<string>(MessageConstants.AccountSid);
                var apiUrl = uri + MessageConstants.Calls + MessageConstants.Json;
                CallListEntity list = await httpHandler.GetRequest<CallListEntity>(apiUrl, AccessToken);

                return list.calls;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<CallOutput> GetCallDetailsBySid(string CallSid)
        {
            try
            {
                string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
                string uri = configuration.GetValue<string>(MessageConstants.uri) + configuration.GetValue<string>(MessageConstants.AccountSid);
                var apiUrl = uri + MessageConstants.Calls + "/" + CallSid + MessageConstants.Json;
                CallOutput  callOutput= await httpHandler.GetRequest<CallOutput>(apiUrl, AccessToken);

                return callOutput;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CallRecordOut> CreateRecord(string CallSid)
        {
            CallRecordReq callRecordEntity = new CallRecordReq();
            callRecordEntity.to = CallSid;
            callRecordEntity.from = configuration.GetValue<string>(MessageConstants.AccountSid);
            try
            {
                string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
                string uri = configuration.GetValue<string>(MessageConstants.uri) + configuration.GetValue<string>(MessageConstants.AccountSid);
                var apiUrl = uri + MessageConstants.Calls +"/"+ CallSid+MessageConstants.Recordings+MessageConstants.Json;
                var json = JsonConvert.SerializeObject(callRecordEntity);
                var Tin = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
                CallRecordOut messageEntity = await httpHandler.PostRequestForAllCreations<Dictionary<string, string>, CallRecordOut>(apiUrl, Tin, AccessToken);

                return messageEntity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<RecordingList>> RecordingList(string RecordingSid)
        {
            try
            {
                string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
                string uri = configuration.GetValue<string>(MessageConstants.uri) + configuration.GetValue<string>(MessageConstants.AccountSid);
                var apiUrl = uri + MessageConstants.Calls +"/"+ RecordingSid +MessageConstants.Recordings+ MessageConstants.Json;
                RecordingListEntity list = await httpHandler.GetRequest<RecordingListEntity>(apiUrl, AccessToken);

                return list.recordings;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<RecordingList> RecordingBySid(CallRecordViewIn CallSid)
        {
            try
            {
                string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
                string uri = configuration.GetValue<string>(MessageConstants.uri) + configuration.GetValue<string>(MessageConstants.AccountSid);
                var apiUrl = uri + MessageConstants.Calls + "/" + CallSid.CallSid +MessageConstants.Recordings+"/"+CallSid.RecordSid+ MessageConstants.Json;
                RecordingList callOutput = await httpHandler.GetRequest<RecordingList>(apiUrl, AccessToken);

                return callOutput;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
