using NeginIBSng.HttpClient;
using NeginIBSng.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NeginIBSng.Handlers.bw;

namespace NeginIBSng.Controllers.bw
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddLeafServiceController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public AddLeafServiceController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Post(SendModel<AddLeafServiceInputModel> model)
        {
            var result = new ApiModol<AddLeafServiceOutputModel>();
            var url = _configuration.GetSection("IBSng").Get<string>();

            using var client = new JsonHttpClient();
            var httpResponse = await client.PostJsonAsync(url, model);
            if (!httpResponse.IsSuccessStatusCode)
            {
                result.Success = false;
                return Ok(result);
            }
            var stringJson = await httpResponse.Content.ReadAsStringAsync();
            var replyModel = Newtonsoft.Json.JsonConvert.DeserializeObject<AddLeafServiceOutputModel>(stringJson);

            replyModel.jsonrpc = "2.0";
            result.Success = true;
            result.Data = replyModel;
            return Ok(result);
        }
    }
}
