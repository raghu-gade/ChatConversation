using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionEntities.Entities
{
    public class RecordingListEntity
    {
        public string first_page_uri { get; set; }
        public int end { get; set; }
        public object previous_page_uri { get; set; }
        public string uri { get; set; }
        public int page_size { get; set; }
        public int start { get; set; }
        public List<RecordingList> recordings { get; set; }
        public object next_page_uri { get; set; }
        public int page { get; set; }
    }
    public class RecordingList
    {
        public string account_sid { get; set; }
        public string api_version { get; set; }
        public string call_sid { get; set; }
        public object conference_sid { get; set; }
        public string date_created { get; set; }
        public string date_updated { get; set; }
        public string start_time { get; set; }
        public string duration { get; set; }
        public string sid { get; set; }
        public string price { get; set; }
        public string price_unit { get; set; }
        public string status { get; set; }
        public int channels { get; set; }
        public string source { get; set; }
        public object error_code { get; set; }
        public string uri { get; set; }
        public object encryption_details { get; set; }
        public SubresourceUrisRec subresource_uris { get; set; }
        public string media_url { get; set; }
    }
    public class SubresourceUrisRec
    {
        public string add_on_results { get; set; }
        public string transcriptions { get; set; }
    }
}
