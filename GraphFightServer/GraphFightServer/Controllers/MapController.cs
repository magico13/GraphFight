using GraphFightCommon;
using GraphFightCommon.Serializers;
using Microsoft.AspNetCore.Mvc;

namespace GraphFightServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        public ActionResult<string> GetMap()
        {
            if (MasterGameController.TheGame.Map == null)
            {
                return NotFound();
            }
            return MapSerializer.Serialize(MasterGameController.TheGame.Map);
        }

        public ActionResult SetMap([FromBody] string map)
        {
            MasterGameController.TheGame.Map = MapSerializer.Deserialize(map, MasterGameController.TheGame.Tiles);

            return Ok();
        }
    }
}