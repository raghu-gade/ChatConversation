using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.Services.UserService
{
    public interface IUserService
    {
        public UserCreationResponse CreateNewUser(UserEntity identity);
        public UserCreationResponse GetUserById(string id);
        public GetUserList GetUsers();
        public UserCreationResponse UpdateUser(UpdateUserEntity user, string id);
    }
}
