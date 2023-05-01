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
    public class Extra_chargeController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public Extra_chargeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Post(SendModel<UpdateInterfaceInputModel> model)
        {
            var result = new ApiModol<UpdateInterfaceOutputModel>();
            var url = _configuration.GetSection("IBSng").Get<string>();

            using var client = new JsonHttpClient();
            var httpResponse = await client.PostJsonAsync(url, model);
            if (!httpResponse.IsSuccessStatusCode)
            {
                result.Success = false;
                return Ok(result);
            }
            var stringJson = await httpResponse.Content.ReadAsStringAsync();
            var replyModel = Newtonsoft.Json.JsonConvert.DeserializeObject<UpdateInterfaceOutputModel>(stringJson);

            replyModel.jsonrpc = "2.0";
            result.Success = true;
            result.Data = replyModel;
            return Ok(result);
        }
    }
}
