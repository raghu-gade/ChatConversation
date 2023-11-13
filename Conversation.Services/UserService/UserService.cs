using Conversation.RequestHandler.MessageHandler;
using Conversation.RequestHandler.UserHandler;
using ConversationAPI.DataAccess.EntityPlatform;
using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.Services.UserService
{
    public class UserService : IUserService
    {
        public readonly IUserHandler userHandler;
        private readonly IEntityHandler entityData;
        public UserService(IUserHandler _userHandler)
        {
            this.userHandler = _userHandler;
           // this.entityData = entityData;
        }

        public UserCreationResponse CreateNewUser(UserEntity identity)
        {
            try
            {
                return this.userHandler.CreateNewUser(identity).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public UserCreationResponse GetUserById(string id)
        {
            try
            {
                return this.userHandler.GetUserById(id).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public GetUserList GetUsers()
        {
            try
            {
                return this.userHandler.GetUsers().Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public UserCreationResponse UpdateUser(UpdateUserEntity user, string id)
        {
            try
            {
                return this.userHandler.UpdateUser(user, id).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
