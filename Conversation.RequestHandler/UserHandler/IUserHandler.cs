using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.RequestHandler.UserHandler
{
    public interface IUserHandler
    {
        Task<UserCreationResponse> CreateNewUser(UserEntity identity);
        Task<UserCreationResponse> GetUserById(string id);
        Task<GetUserList> GetUsers();
        Task<UserCreationResponse> UpdateUser(UpdateUserEntity user, string id);
    }
}
