using Conversation.RequestHandler.CallHandler;
using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.Services.CallService
{
    public class CallService : ICallService
    {
        public readonly ICallHandler callHandler;
        public CallService(ICallHandler _callHandler)
        {
            this.callHandler = _callHandler;
        }
        public CallOutput MakeACall(CallMaking callMaking)
        {
            try
            {
                return this.callHandler.MakeACall(callMaking).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<CallOutput> CallsList()
        {
            try
            {
                return this.callHandler.CallsList().Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public CallOutput GetCallDetailsBySid(string CallSid)
        {
            try
            {
                return this.callHandler.GetCallDetailsBySid(CallSid).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public CallRecordOut CreateRecord(string CallSid)
        {
            try
            {
                return this.callHandler.CreateRecord(CallSid).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<RecordingList> RecordingList(string RecordSid)
        {
            try
            {
                return this.callHandler.RecordingList(RecordSid).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public RecordingList RecordingBySid(CallRecordViewIn CallSid)
        {
            try
            {
                return this.callHandler.RecordingBySid(CallSid).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
