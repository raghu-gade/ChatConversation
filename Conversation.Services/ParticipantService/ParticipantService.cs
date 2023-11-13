using Conversation.RequestHandler.ChatHandler;
using Conversation.RequestHandler.ParticipantHandler;
using ConversationAPI.DataAccess.EntityPlatform;
using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.Services.ParticipantService
{
    public class ParticipantService:IParticipantService
    {
        public readonly IParticipantHandler participantHandler;
        private readonly IEntityHandler entityData;
        public ParticipantService(IParticipantHandler _participantHandler)
        {
            this.participantHandler = _participantHandler;
            //this.entityData = entityData;
        }
        public AddParticipateToConversation AddParticipant(UserEntity msgAddress, string MessageSid)
        {
            try
            {
                return this.participantHandler.AddParticipant(msgAddress, MessageSid).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
