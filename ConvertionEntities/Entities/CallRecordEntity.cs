using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionEntities.Entities
{
    public class CallRecordEntity
    {
        public string AcountSid { get; set; }
        public string CallSid { get; set; }
    }
    public class CallRecordReq
    {
        public string from { get; set; }
        public string to { get; set; }
    }
}
