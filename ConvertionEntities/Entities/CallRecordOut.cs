using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionEntities.Entities
{
    public class CallRecordOut
    {
        public string status { get; set; }
        public object conference_sid { get; set; }
        public object price_unit { get; set; }
        public string date_updated { get; set; }
        public string start_time { get; set; }
        public string uri { get; set; }
        public string account_sid { get; set; }
        public int channels { get; set; }
        public string source { get; set; }
        public object encryption_details { get; set; }
        public string track { get; set; }
        public string call_sid { get; set; }
        public string sid { get; set; }
        public object duration { get; set; }
        public string date_created { get; set; }
        public object error_code { get; set; }
        public object price { get; set; }
        public string api_version { get; set; }
    }
}
