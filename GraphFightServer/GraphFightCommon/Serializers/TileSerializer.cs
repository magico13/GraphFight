using Newtonsoft.Json;

namespace GraphFightCommon.Serializers
{
    public class TileSerializer
    {
        public static string Serialize(Tile tile)
        {
            return JsonConvert.SerializeObject(new { tile.Id, tile.MovementFlags });
        }
    }
}
