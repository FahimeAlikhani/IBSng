using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace NeginIBSng.HttpClient
{
    public class JsonHttpClient : System.Net.Http.HttpClient
    {
        public async Task<HttpResponseMessage> PostJsonAsync(string requestUri, object data)
        {
            var jsonData = JsonConvert.SerializeObject(data);
            var content = new JsonContent(jsonData);
            return await PostAsync(requestUri, content);
        }
    }
}
