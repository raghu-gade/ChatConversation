using Conversation.RequestHandler.Account;
using Conversation.RequestHandler.CallHandler;
using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.Services.Accounts
{
    public class Accountservice: IAccountService
    {
        public readonly IAccountsHandler accountsHandler;
        public Accountservice(IAccountsHandler _accountsHandler)
        {
            this.accountsHandler = _accountsHandler;
        }

        public SubAccountReturn CreateSubAccount(SubAccountCreate subAccountCreate)
        {
            try
            {
                return this.accountsHandler.CreateSubAccount(subAccountCreate).Result;
            }
            catch (Exception ex)
            {

                throw;
            }
          
            //throw new NotImplementedException();
        }
    }
}
