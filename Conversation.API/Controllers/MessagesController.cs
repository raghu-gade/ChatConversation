using Conversation.Services.MessageService;
using ConvertionEntities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace Conversation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService messageService;
        public MessagesController(IMessageService messageService)
        {
            this.messageService = messageService;
        }
        [HttpGet]
        public ActionResult<List<MessageListEntity>> MessagesList()
        {

            var result = this.messageService.MessagesList();
            return result;
        }
        [HttpGet("messageSid /{messageSid}")]
        public ActionResult<MessageListEntity> GetMessageBySid(string messageSid)
        {

            var result = this.messageService.GetMessageBySid(messageSid);
            return result;
        }
        [HttpPost("")]
        public ActionResult<MessageListEntity> CreateMessage(CreateMessageTIn createMessage)
        {

            var result = this.messageService.CreateMessage(createMessage);
            return result;
        }
        [HttpDelete("DeleteMessage")]
        public ActionResult<string> DeleteMessage(string messageSid)
        {

            var result = this.messageService.DeleteMessage(messageSid);
            return result;
        }

        [HttpPost("ModifyMessage")]
        public ActionResult<MessageListEntity> ModifyMessage(ModifyMessage modifyMessage)
        {

            var result = this.messageService.ModifyMessage(modifyMessage);
            return result;
        }        
    }
}
