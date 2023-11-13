using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionEntities.Entities
{
    public class SubAccountReturn
    {
        public string status { get; set; }
        public string date_updated { get; set; }
        public string auth_token { get; set; }
        public string friendly_name { get; set; }
        public string owner_account_sid { get; set; }
        public string uri { get; set; }
        public string sid { get; set; }
        public string date_created { get; set; }
        public string type { get; set; }
        public SubresourceUrisAc subresource_uris { get; set; }
    }

    public class SubresourceUrisAc
    {
        public string addresses { get; set; }
        public string conferences { get; set; }
        public string signing_keys { get; set; }
        public string transcriptions { get; set; }
        public string connect_apps { get; set; }
        public string sip { get; set; }
        public string authorized_connect_apps { get; set; }
        public string usage { get; set; }
        public string keys { get; set; }
        public string applications { get; set; }
        public string recordings { get; set; }
        public string short_codes { get; set; }
        public string calls { get; set; }
        public string notifications { get; set; }
        public string incoming_phone_numbers { get; set; }
        public string queues { get; set; }
        public string messages { get; set; }
        public string outgoing_caller_ids { get; set; }
        public string available_phone_numbers { get; set; }
        public string balance { get; set; }
    }
}
