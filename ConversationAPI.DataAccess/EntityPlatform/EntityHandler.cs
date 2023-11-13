using ConvertionEntities.Common;
using ConvertionEntities.Entities;
using System.Data;
using System.Data.SqlClient;
using VAMLibrary.Core;
using VAMLibrary.Core.Common;

namespace ConversationAPI.DataAccess.EntityPlatform
{
    public class EntityHandler : IEntityHandler
    {
        private readonly DataAccessHelper dataAccessHelper;

        public EntityHandler(DataAccessHelper dataAccessHelper)
        {
            this.dataAccessHelper = dataAccessHelper;
        }

        public DataSet FillAccountData(SubAccountReturn subAccountReturn)
        {
            try
            {
                DataSet dataSet = new DataSet();
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = RequestContextConstants.UID, Value = subAccountReturn.sid });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = RequestContextConstants.Name, Value = subAccountReturn.friendly_name });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = RequestContextConstants.Email, Value = "" });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = RequestContextConstants.PhoneNo, Value = "" });
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = RequestContextConstants.Password, Value = "" });
                sqlparms.Add(new SqlParameter { DbType = DbType.Boolean, ParameterName = RequestContextConstants.ISDeleted, Value = false });
                DataSet dataset = (DataSet)dataAccessHelper.ExecuteStoredProcedure(EntitySPConstants.Sp_AddAccounts, sqlparms, ExecutionType.Dataset);
                return dataSet;
            }
            catch (Exception ex)
            {

                throw;
            }
            throw new NotImplementedException();
        }

        public DataSet GetAllEntityCategory()
        {
            try
            {
                List<SqlParameter> sqlparms = new List<SqlParameter>();
                sqlparms.Add(new SqlParameter { DbType = DbType.String, ParameterName = RequestContextConstants.Id, Value = 1 });
                DataSet dataset = (DataSet)dataAccessHelper.ExecuteStoredProcedure(EntitySPConstants.Sp_GetDatasmpl, sqlparms, ExecutionType.Dataset);
                return dataset;
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
