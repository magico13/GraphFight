using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GraphFightCommon.Serializers
{
    public static class MapSerializer
    {
        public static string Serialize(Map map)
        {
            var toSerialize = new
            {
                map.Width,
                map.Height,
                Tiles = map.Tiles.Select(w => w.Select(h => h.Id))
            };

            return JsonConvert.SerializeObject(toSerialize);
        }

        public static Map Deserialize(string source, IEnumerable<Tile> tiles)
        {
            JObject obj = JObject.Parse(source);
            var ints = (obj.GetValue("Tiles") as JArray).ToObject<IEnumerable<IEnumerable<int>>>();

            IEnumerable<IEnumerable<Tile>> intToTiles = ints.Select(l => l.Select(i => tiles.First(t => t.Id == i)));

            return new Map(intToTiles);
            //return null;
        }
    }
}
