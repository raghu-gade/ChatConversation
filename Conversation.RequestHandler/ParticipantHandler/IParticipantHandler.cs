using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.RequestHandler.ParticipantHandler
{
    public interface IParticipantHandler
    {
        Task<AddParticipateToConversation> AddParticipant(UserEntity msgAddress, string MessageSid);
    }
}
