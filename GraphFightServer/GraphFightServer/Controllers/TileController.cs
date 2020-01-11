using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraphFightServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TileController : ControllerBase
    {
        public string GetTiles()
        {
            return string.Empty;
        }

        [Route("api/[controller]/[id]")]
        public string GetTile([FromRoute]int id)
        {
            return id.ToString();
        }
    }
}