using ConvertionEntities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversationAPI.DataAccess.EntityPlatform
{
    public interface IEntityHandler
    {
        DataSet GetAllEntityCategory();
        DataSet FillAccountData(SubAccountReturn subAccountReturn);
    }
}
