using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NeginIBSng.HttpClient
{
    public class JsonContent : StringContent
    {
        public JsonContent(string content)
            : base(content, Encoding.UTF8, "application/json")
        {
        }
    }
}
