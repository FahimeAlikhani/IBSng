using NeginIBSng.HttpClient;
using NeginIBSng.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NeginIBSng.Handlers.isp;

namespace NeginIBSng.Controllers.isp
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChangeISPDepositController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public ChangeISPDepositController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Post(SendModel<ChangeISPDepositInputModel> model)
        {
            var result = new ApiModol<ChangeISPDepositOutputModel>();
            var url = _configuration.GetSection("parspooyesh").Get<string>();

            using var client = new JsonHttpClient();
            var httpResponse = await client.PostJsonAsync(url, model);
            if (!httpResponse.IsSuccessStatusCode)
            {
                result.Success = false;
                return Ok(result);
            }
            var stringJson = await httpResponse.Content.ReadAsStringAsync();
            var replyModel = Newtonsoft.Json.JsonConvert.DeserializeObject<ChangeISPDepositOutputModel>(stringJson);

            replyModel.jsonrpc = "2.0";
            result.Success = true;
            result.Data = replyModel;
            return Ok(result);
        }
    }
}
