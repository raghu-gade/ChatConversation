using Conversation.Services.ParticipantService;
using Conversation.Services.UserService;
using ConvertionEntities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Conversation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantController : ControllerBase
    {
        private readonly IParticipantService participantService;
        public ParticipantController(IParticipantService participantService)
        {
            this.participantService = participantService;
        }

        [HttpPost("AddParticipant")]
        public ActionResult<AddParticipateToConversation> AddParticipant(UserEntity msgAddress, string MessageSid)
        {
            var result = this.participantService.AddParticipant(msgAddress, MessageSid);
            return result;
        } 

    }
}
