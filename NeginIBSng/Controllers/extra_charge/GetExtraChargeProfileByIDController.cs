﻿using NeginIBSng.HttpClient;
using NeginIBSng.Handlers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NeginIBSng.Handlers.extra_charge;

namespace NeginIBSng.Controllers.extra_charge
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetExtraChargeProfileByIDController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public GetExtraChargeProfileByIDController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<IActionResult> Post(SendModel<GetExtraChargeProfileByIDInputModel> model)
        {
            var result = new ApiModol<GetExtraChargeProfileByIDOutputModel>();
            var url = _configuration.GetSection("parspooyesh").Get<string>();

            using var client = new JsonHttpClient();
            var httpResponse = await client.PostJsonAsync(url, model);
            if (!httpResponse.IsSuccessStatusCode)
            {
                result.Success = false;
                return Ok(result);
            }
            var stringJson = await httpResponse.Content.ReadAsStringAsync();
            var replyModel = Newtonsoft.Json.JsonConvert.DeserializeObject<GetExtraChargeProfileByIDOutputModel>(stringJson);

            replyModel.jsonrpc = "2.0";
            result.Success = true;
            result.Data = replyModel;
            return Ok(result);
        }
    }
}