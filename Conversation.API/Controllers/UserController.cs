using Conversation.Services.Chat;
using Conversation.Services.UserService;
using ConvertionEntities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Conversation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost("NewUser")]
        public ActionResult<UserCreationResponse> CreateNewUser(UserEntity identity)
        {

            var result = this.userService.CreateNewUser(identity);
            return result;
        }

        [HttpGet("GetUserById")]
        public ActionResult<UserCreationResponse> GetUserById(string id)
        {

            var result = this.userService.GetUserById(id);
            return result;
        }

        [HttpGet("GetUsers")]
        public ActionResult<GetUserList> GetUsers()
        {

            var result = this.userService.GetUsers();
            return result;
        }
        [HttpPost("UpdateUser")]
        public ActionResult<UserCreationResponse> UpdateUser(UpdateUserEntity user, string id)
        {

            var result = this.userService.UpdateUser(user, id);
            return result;
        }


    }
}
