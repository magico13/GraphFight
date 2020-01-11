using System;
using System.Collections.Generic;
using System.Text;

namespace GraphFightCommon.Serializers
{
    public static class MapSerializer
    {
        public static string Serialize(Map map)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(map);
        }
    }
}
