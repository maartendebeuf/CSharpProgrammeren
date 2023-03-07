using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.ResponseModel
{
    public class PublicAPIResponse
    {
        public int count { get; set; }
        public List<APIResponse> entries { get; set; }
}
}
