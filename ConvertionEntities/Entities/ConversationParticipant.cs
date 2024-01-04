using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionEntities.Entities
{


    public class Participant
    {
        public int? last_read_message_index { get; set; }
        public DateTime date_updated { get; set; }
        public DateTime? last_read_timestamp { get; set; }
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

    public class ConversationParticipant
    {
        public List<Participant> participants { get; set; }
        public Meta meta { get; set; }
    }

}
