using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionEntities.Entities
{
    public class Conversations
    {
        public List<ChatEntity> conversations { get; set; }
        public Meta meta { get; set; }
    }
    public class ChatFriendlyName
    {
        public string FriendlyName { get; set; }
    }
    
    public class ChatEntity
    {
        public string unique_name { get; set; }
        public DateTime date_updated { get; set; }
        public string friendly_name { get; set; }
        public Timers timers { get; set; }
        public string account_sid { get; set; }
        public string url { get; set; }
        public string state { get; set; }
        public DateTime date_created { get; set; }
        public string messaging_service_sid { get; set; }
        public string sid { get; set; }
        public string attributes { get; set; }
        public string bindings { get; set; }
        public string chat_service_sid { get; set; }
        public Links links { get; set; }
    }
    public class Links
    {
        public string participants { get; set; }
        public string messages { get; set; }
        public string webhooks { get; set; }
    }

    public class Timers
    {
    }

    //public class AccessToken
    //{
    //     public string token { get; set; }
    //}

    public class AddParticipateToConversation
    {
        public string last_read_message_index { get; set; }
        public DateTime date_updated { get; set; }
        public string last_read_timestamp { get; set; }
        public string conversation_sid { get; set; }
        public string account_sid { get; set; }
        public string url { get; set; }
        public DateTime date_created { get; set; }
        public string role_sid { get; set; }
        public string sid { get; set; }
        public string attributes { get; set; }
        public string identity { get; set; }
        public MessagingBinding messaging_binding { get; set; }
    }
    public class MessagingBinding
    {
        public string proxy_address { get; set; }
        public string type { get; set; }
        public string address { get; set; }
    }
    public class MyProperty { 
        public AddParticipateBody AddParticipateBody { get; set; }

    }
    public class AddParticipateBody
    {
        public string Address { get; set; }
        public string ProxyAddress { get; set; }
    }
    public class Meta
    {
        public int page { get; set; }
        public int page_size { get; set; }
        public string first_page_url { get; set; }
        public object previous_page_url { get; set; }
        public string url { get; set; }
        public object next_page_url { get; set; }
        public string key { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class MessageLinks
    {
        public string delivery_receipts { get; set; }
        public string channel_metadata { get; set; }
    }

    public class Message
    {
        public string body { get; set; }
        public int index { get; set; }
        public string author { get; set; }
        public DateTime date_updated { get; set; }
        public object media { get; set; }
        public string participant_sid { get; set; }
        public string conversation_sid { get; set; }
        public string account_sid { get; set; }
        public object delivery { get; set; }
        public string url { get; set; }
        public DateTime date_created { get; set; }
        public object content_sid { get; set; }
        public string sid { get; set; }
        public string attributes { get; set; }
        public MessageLinks links { get; set; }
    }


    public class MessageEntity
    {
        public Meta meta { get; set; }
        public List<Message> messages { get; set; }
    }






}
