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

            return Newtonsoft.Json.JsonConvert.SerializeObject(toSerialize);
        }
    }
}
