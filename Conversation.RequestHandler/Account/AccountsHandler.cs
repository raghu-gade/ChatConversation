using ConversationAPI.DataAccess.EntityPlatform;
using ConvertionEntities.Common;
using ConvertionEntities.Constants;
using ConvertionEntities.Entities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RequestHandler;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversation.RequestHandler.Account
{
    public class AccountsHandler : IAccountsHandler
    {
        public IConfiguration configuration { get; }
        private readonly IHttpHandler httpHandler;
        private readonly IEntityHandler entityHandler;
        public AccountsHandler(IConfiguration configurations, IHttpHandler httpHandler, IEntityHandler entityHandler)
        {
            this.configuration = configurations;
            this.httpHandler = httpHandler;
            this.entityHandler = entityHandler;
        }
        public async Task<SubAccountReturn> CreateSubAccount(SubAccountCreate subAccountCreate)
        {
            try
            {
                string AccessToken = configuration.GetValue<string>(MessageConstants.AccountSid) + ":" + configuration.GetValue<string>(MessageConstants.AuthToken);
                string uri = configuration.GetValue<string>(MessageConstants.uri) + configuration.GetValue<string>(MessageConstants.AccountSid);
                var apiUrl = uri + MessageConstants.Accounts + MessageConstants.Json;

                var json = JsonConvert.SerializeObject(subAccountCreate);
                var Tin = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                SubAccountReturn subAccountReturn = await httpHandler.PostRequestForAllCreations<Dictionary<string, string>, SubAccountReturn>(apiUrl, Tin, AccessToken);
                if (subAccountReturn.status == ErrorCodes.Success || subAccountReturn.status == ErrorCodes.PartiallySuccess)
                {
                    DataSet dataset = this.entityHandler.FillAccountData(subAccountReturn);
                    DataTable dataTable = dataset.Tables[0];
                }
                return subAccountReturn;
            }
            catch (Exception ex)
            {

                throw;
            }
           
        }
    }
}
