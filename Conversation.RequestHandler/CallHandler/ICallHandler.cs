using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.RequestHandler.CallHandler
{
    public interface ICallHandler
    {
        Task<CallOutput> MakeACall(CallMaking callMaking);
        Task<List<CallOutput>> CallsList();
        Task<CallOutput> GetCallDetailsBySid(string CallSid);
        Task<CallRecordOut> CreateRecord(string CallSid);
        Task<List<RecordingList>> RecordingList(string RecordSid);
        Task<RecordingList> RecordingBySid(CallRecordViewIn CallSid);

    }
}
