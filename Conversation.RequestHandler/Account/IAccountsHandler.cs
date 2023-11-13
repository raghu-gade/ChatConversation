using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.RequestHandler.Account
{
    public interface IAccountsHandler
    {
        Task<SubAccountReturn> CreateSubAccount(SubAccountCreate subAccountCreate);
    }
}
