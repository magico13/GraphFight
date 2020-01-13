using Newtonsoft.Json;
using System;
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

        public static List<Tile> DeserializeList(string source)
        {
            return JsonConvert.DeserializeObject<List<Tile>>(source);
        }

        public static Tile Deserialize(string source)
        {
            return JsonConvert.DeserializeObject<Tile>(source);
        }
    }
}
