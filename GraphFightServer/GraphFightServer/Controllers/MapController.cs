﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphFightCommon;
using GraphFightCommon.Serializers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraphFightServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        public string GetMap()
        {
            return MapSerializer.Serialize(MasterGameController.TheGame.Map);
        }

        public IActionResult SetMap([FromBody] string map)
        {


            return Ok();
        }
    }
}