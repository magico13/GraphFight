using Newtonsoft.Json;
using System.Collections.Generic;

namespace GraphFightCommon.Serializers
{
    public class TileSerializer
    {
        public static string Serialize(Tile tile)
        {
            return JsonConvert.SerializeObject(tile);
        }

        public static string SerializeList(List<Tile> list)
        {
            return JsonConvert.SerializeObject(list);
        }
    }
}
