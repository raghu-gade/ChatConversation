using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionEntities.Entities
{
    public class CallOutput
    {
        public object date_updated { get; set; }
        public string price_unit { get; set; }
        public object parent_call_sid { get; set; }
        public object caller_name { get; set; }
        public object duration { get; set; }
        public string from { get; set; }
        public string to { get; set; }
        public object annotation { get; set; }
        public object answered_by { get; set; }
        public string sid { get; set; }
        public string queue_time { get; set; }
        public object price { get; set; }
        public string api_version { get; set; }
        public string status { get; set; }
        public string direction { get; set; }
        public object start_time { get; set; }
        public object date_created { get; set; }
        public string from_formatted { get; set; }
        public object group_sid { get; set; }
        public object trunk_sid { get; set; }
        public object forwarded_from { get; set; }
        public string uri { get; set; }
        public string account_sid { get; set; }
        public object end_time { get; set; }
        public string to_formatted { get; set; }
        public string phone_number_sid { get; set; }
        public SubresourceUrisCall subresource_uris { get; set; }

    }
    public class SubresourceUrisCall
    {
        public string feedback { get; set; }
        public string user_defined_messages { get; set; }
        public string notifications { get; set; }
        public string recordings { get; set; }
        public string streams { get; set; }
        public string payments { get; set; }
        public string user_defined_message_subscriptions { get; set; }
        public string siprec { get; set; }
        public string events { get; set; }
        public string feedback_summaries { get; set; }
    }
}
