using Conversation.Services.Accounts;
using Conversation.Services.CallService;
using ConvertionEntities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Conversation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService accountService;
        public AccountsController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost("")]
        public ActionResult<SubAccountReturn> CreateSubAccount(SubAccountCreate subAccountCreate)
        {

            var result = this.accountService.CreateSubAccount(subAccountCreate);
            return result;
        }
    }
}
