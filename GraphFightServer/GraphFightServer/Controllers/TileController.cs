using GraphFightCommon;
using GraphFightCommon.Serializers;
using Microsoft.AspNetCore.Mvc;

namespace GraphFightServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TileController : ControllerBase
    {
        public string GetTiles()
        {
            return TileSerializer.SerializeList(MasterGameController.TheGame.Tiles);
        }

        [Route("api/[controller]/[id]")]
        public string GetTile([FromRoute]int id)
        {
            Tile tile = MasterGameController.TheGame.Tiles.Find(t => t.Id == id);
            return TileSerializer.Serialize(tile);
        }
    }
}