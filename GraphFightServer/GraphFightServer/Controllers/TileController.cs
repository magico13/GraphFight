using GraphFightCommon;
using GraphFightCommon.Serializers;
using Microsoft.AspNetCore.Mvc;

namespace GraphFightServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TileController : ControllerBase
    {
        public ActionResult<string> GetTiles()
        {
            if (MasterGameController.TheGame.Tiles == null)
            {
                return NotFound();
            }
            return TileSerializer.SerializeList(MasterGameController.TheGame.Tiles);
        }

        [Route("{id}")]
        public ActionResult<string> GetTile([FromRoute]int id)
        {
            Tile tile = MasterGameController.TheGame.Tiles?.Find(t => t.Id == id);
            if (tile == null)
            {
                return NotFound();
            }
            return TileSerializer.Serialize(tile);
        }
    }
}