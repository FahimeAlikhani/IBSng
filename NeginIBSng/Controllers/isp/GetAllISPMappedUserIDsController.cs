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
    public class GetAllISPMappedUserIDsController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public GetAllISPMappedUserIDsController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Post(SendModel<GetAllISPMappedUserIDsInputModel> model)
        {
            var result = new ApiModol<GetAllISPMappedUserIDsOutputModel>();
            var url = _configuration.GetSection("parspooyesh").Get<string>();

            using var client = new JsonHttpClient();
            var httpResponse = await client.PostJsonAsync(url, model);
            if (!httpResponse.IsSuccessStatusCode)
            {
                result.Success = false;
                return Ok(result);
            }
            var stringJson = await httpResponse.Content.ReadAsStringAsync();
            var replyModel = Newtonsoft.Json.JsonConvert.DeserializeObject<GetAllISPMappedUserIDsOutputModel>(stringJson);

            replyModel.jsonrpc = "2.0";
            result.Success = true;
            result.Data = replyModel;
            return Ok(result);
        }
    }
}
