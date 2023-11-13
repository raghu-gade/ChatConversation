using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionEntities.Entities
{
    public class UserEntity
    {
        public string Identity { get; set; }
    }
    public class UpdateUserEntity
    {
        public string FriendlyName { get; set; }
        public string RoleSid { get; set; }
    }

    public class UserCreationResponse
    {
        public bool? is_notifiable { get; set; }
        public DateTime date_updated { get; set; }
        public bool? is_online { get; set; }
        public string friendly_name { get; set; }
        public string account_sid { get; set; }
        public string url { get; set; }
        public DateTime date_created { get; set; }
        public string role_sid { get; set; }
        public string sid { get; set; }
        public string attributes { get; set; }
        public string identity { get; set; }
        public string chat_service_sid { get; set; }
        public UserLinks links { get; set; }
    }
    public class UserLinks
    {
        public string user_conversations { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
  

    public class UserMeta
    {
        public int page { get; set; }
        public int page_size { get; set; }
        public string first_page_url { get; set; }
        public object previous_page_url { get; set; }
        public string url { get; set; }
        public object next_page_url { get; set; }
        public string key { get; set; }
    }

    public class GetUserList
    {
        public UserMeta meta { get; set; }
        public List<UserCreationResponse> users { get; set; }
    }

    




}
