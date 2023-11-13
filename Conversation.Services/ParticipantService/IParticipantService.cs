﻿using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.Services.ParticipantService
{
    public interface IParticipantService 
    { 
        AddParticipateToConversation AddParticipant(UserEntity msgAddress, string MessageSid);
    
    }
}
