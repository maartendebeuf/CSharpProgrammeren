using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.ResponseModel
{
    public class CatResponse
    {
        public int current_page { get; set; }
        public string next_page_url { get; set; }
        public List<Breed> data { get; set; }
    }
    public class Breed
    {
        public string breed { get; set; }
        public string country { get; set; }
        public string origin { get; set; }
        public string coat { get; set; }
        public string pattern { get; set; }

    }
}
