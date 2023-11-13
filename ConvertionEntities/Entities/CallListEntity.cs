using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertionEntities.Entities
{
    public class CallListEntity
    {
        public string first_page_uri { get; set; }
        public int end { get; set; }
        public List<CallOutput> calls { get; set; }
        public object previous_page_uri { get; set; }
        public string uri { get; set; }
        public int page_size { get; set; }
        public int start { get; set; }
        public object next_page_uri { get; set; }
        public int page { get; set; }
    }
   
}
