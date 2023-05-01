using NeginIBSng.HttpClient;
using NeginIBSng.Handlers;
using Microsoft.AspNetCore.Mvc;
using NeginIBSng.Handlers.perm;

namespace NeginIBSng.Controllers.charge
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllPermsControllers : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public GetAllPermsControllers(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Post(SendModel<GetAllPermsInputModel> model)
        {
            var result = new ApiModol<GetAllPermsOutputModel>();
            var url = _configuration.GetSection("IBSng").Get<string>();

            using var client = new JsonHttpClient();
            var httpResponse = await client.PostJsonAsync(url, model);
            if (!httpResponse.IsSuccessStatusCode)
            {
                result.Success = false;
                return Ok(result);
            }
            var stringJson = await httpResponse.Content.ReadAsStringAsync();
            var replyModel = Newtonsoft.Json.JsonConvert.DeserializeObject<GetAllPermsOutputModel>(stringJson);

            replyModel.jsonrpc = "2.0";
            result.Success = true;
            result.Data = replyModel;
            return Ok(result);
        }
    }
}
