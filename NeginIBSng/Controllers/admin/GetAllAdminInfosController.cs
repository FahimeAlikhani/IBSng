using NeginIBSng.HttpClient;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NeginIBSng.Handlers.admin;
using NeginIBSng.Handlers;

namespace NeginIBSng.Controllers.admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllAdminInfosController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public GetAllAdminInfosController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Post(SendModel<GetAllAdminInfosInputModel> model)
        {
            var result = new ApiModol<GetAllAdminInfosOutputModel>();
            var url = _configuration.GetSection("IBSng").Get<string>();

            using var client = new JsonHttpClient();
            var httpResponse = await client.PostJsonAsync(url, model);
            if (!httpResponse.IsSuccessStatusCode)
            {
                result.Success = false;
                return Ok(result);
            }
            var stringJson = await httpResponse.Content.ReadAsStringAsync();
            var replyModel = Newtonsoft.Json.JsonConvert.DeserializeObject<GetAllAdminInfosOutputModel>(stringJson);

            replyModel.jsonrpc = "2.0";
            result.Success = true;
            result.Data = replyModel;
            return Ok(result);
        }
    }
}
