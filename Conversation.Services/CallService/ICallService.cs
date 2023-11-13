using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.Services.CallService
{
    public interface ICallService
    {
        public CallOutput MakeACall(CallMaking callMaking);
        public List<CallOutput> CallsList();
        public CallOutput GetCallDetailsBySid(string CallSid);
        public CallRecordOut CreateRecord(string CallSid);
        public List<RecordingList> RecordingList(string RecordSid);
        public RecordingList RecordingBySid(CallRecordViewIn CallSid);
    }
}
