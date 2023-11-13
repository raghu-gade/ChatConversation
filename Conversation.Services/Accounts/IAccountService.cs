using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.Services.Accounts
{
    public interface IAccountService
    {
        public SubAccountReturn CreateSubAccount(SubAccountCreate subAccountCreate);
    }
}
