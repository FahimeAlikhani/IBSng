﻿using NeginIBSng.HttpClient;
using NeginIBSng.Handlers;
using Microsoft.AspNetCore.Mvc;
using NeginIBSng.Handlers.perm;

namespace NeginIBSng.Controllers.charge
{
    [Route("api/[controller]")]
    [ApiController]
    public class DelPermissionValueControllers : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public DelPermissionValueControllers(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Post(SendModel<DelPermissionValueInputModel> model)
        {
            var result = new ApiModol<DelPermissionValueOutputModel>();
            var url = _configuration.GetSection("IBSng").Get<string>();

            using var client = new JsonHttpClient();
            var httpResponse = await client.PostJsonAsync(url, model);
            if (!httpResponse.IsSuccessStatusCode)
            {
                result.Success = false;
                return Ok(result);
            }
            var stringJson = await httpResponse.Content.ReadAsStringAsync();
            var replyModel = Newtonsoft.Json.JsonConvert.DeserializeObject<DelPermissionValueOutputModel>(stringJson);

            result.Success = true;
            result.Data = replyModel;
            return Ok(result);
        }



    }

}
