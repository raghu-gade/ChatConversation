using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionEntities.Entities
{
    public class BD_Accounts
    {
        public int Id { get; set; }
        public string UID { get; set; }
        public string NAME { get; set; }
        public string EMAIL { get; set; }
        public string PHONENO { get; set; }
        public string PASSWORD { get; set; }
        public string IS_DELETED { get; set; }
        public string CREATED_DATE { get; set; }
        public string UPDATED_DATE { get; set; }
    }
}
