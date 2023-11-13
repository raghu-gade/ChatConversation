using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionEntities.Entities
{
    public class SendNotificationByIdentity
    {
        public string body { get; set; }
        public object sound { get; set; }
        public object sms { get; set; }
        public object alexa { get; set; }
        public object facebook_messenger { get; set; }
        public List<object> tags { get; set; }
        public object title { get; set; }
        public List<object> segments { get; set; }
        public int ttl { get; set; }
        public object gcm { get; set; }
        public string account_sid { get; set; }
        public string priority { get; set; }
        public object apn { get; set; }
        public object data { get; set; }
        public string sid { get; set; }
        public object action { get; set; }
        public DateTime date_created { get; set; }
        public string service_sid { get; set; }
        public List<string> identities { get; set; }
        public object fcm { get; set; }
    }
    public class NotificationsBody
    {
        public string Body { get; set; }
        public string Identity { get; set; }
    }
}