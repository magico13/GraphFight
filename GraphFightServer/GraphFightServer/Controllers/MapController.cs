using GraphFightCommon;
using GraphFightCommon.Serializers;
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
            MasterGameController.TheGame.Map = MapSerializer.Deserialize(map, null);

            return Ok();
        }
    }
}