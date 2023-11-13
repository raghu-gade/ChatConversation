using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionEntities.Entities
{
    public class CallMaking
    {
        public string to { get; set; }
        public string from { get; set; }
        public string url { get; set; }
        public string twiml { get; set; }
        public string applicationSid { get; set; }
    }
}
