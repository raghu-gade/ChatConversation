using Conversation.Services.CallService;
using Conversation.Services.MessageService;
using ConvertionEntities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Conversation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CallController : ControllerBase
    {
        private readonly ICallService callService;
        public CallController(ICallService callService)
        {
            this.callService = callService;
        }
        [HttpPost("")]
        public ActionResult<CallOutput> MakeACall(CallMaking callMaking)
        {

            var result = this.callService.MakeACall(callMaking);
            return result;
        }
        [HttpGet]
        public ActionResult<List<CallOutput>> CallsList()
        {

            var result = this.callService.CallsList();
            return result;
        }
        [HttpGet("callSid /{callSid}")]
        public ActionResult<CallOutput> GetMessageBySid(string callSid)
        {

            var result = this.callService.GetCallDetailsBySid(callSid);
            return result;
        }
        [HttpPost("CreateRecord")]
        public ActionResult<CallRecordOut> CreateRecord(string CallSid)
        {

            var result = this.callService.CreateRecord(CallSid);
            return result;
        }
        [HttpGet("RecordingList/{RecordSid}")]
        public ActionResult<List<RecordingList>> RecordingList(string RecordSid)
        {

            var result = this.callService.RecordingList(RecordSid);
            return result;
        }
        [HttpPost("RecordingBySid")]
        public ActionResult<RecordingList> RecordingBySid(CallRecordViewIn callSid)
        {

            var result = this.callService.RecordingBySid(callSid);
            return result;
        }
    }
}
