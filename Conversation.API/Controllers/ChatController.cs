using Conversation.Services.Chat;
using ConvertionEntities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Conversation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatService chatService;
        public ChatController(IChatService chatService)
        {
            this.chatService = chatService;
        }

        [HttpPost("CreateFriendlyName")]
        public ActionResult<ChatEntity> CreateFirstConversation(ChatFriendlyName friendlyName)
        {

            var result = this.chatService.CreateFirstConversation(friendlyName);
            return result;
        }
        [HttpGet("FetchConversation")]
        public ActionResult<ChatEntity> FetchConversation(string MessageSid)
        {

            var result = this.chatService.FetchConversation(MessageSid);
            return result;
        }
        [HttpGet("GetAllConversations")]
        public ActionResult<Conversations> GetAllConversations()
        {

            var result = this.chatService.GetAllConversations();
            return result;
        }
        [HttpGet("GetMessagesByConversationId")]
        public ActionResult<MessageEntity> GetMessagesByConversationId(string ConversationId)
        {

            var result = this.chatService.GetMessagesByConversationId(ConversationId);
            return result;
        }

        [HttpGet]
        public ActionResult CreateChatAccessToken(string name)
        {

            var result = this.chatService.CreateChatAccessToken(name);
            return Ok(Tuple.Create(result, "ok"));
            //return Ok(result);

        }

        [HttpGet("CreateVideoAccessToken")]
        public ActionResult CreateVideoAccessToken(string name)
        {

            var result = this.chatService.CreateVideoAccessToken(name);
            return Ok(Tuple.Create(result, "ok"));
            //return Ok(result);

        }
        [HttpPost("SendNotificationByIdentity")]
        public ActionResult<SendNotificationByIdentity> SendNotificationByIdentity(NotificationsBody msgBody)
        {
            var result = this.chatService.SendNotificationByIdentity(msgBody);
            return result;

        }




    }
}