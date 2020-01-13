using GraphFightCommon.Serializers;
using System.Collections.Generic;
using System.IO;

namespace GraphFightCommon.Loaders
{
    public static class TileLoader
    {
        public static List<Tile> Load(string filepath)
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException("Failure to load tiles from provided file. File not found.", filepath);
            }
            string fileData = File.ReadAllText(filepath);
            return TileSerializer.DeserializeList(fileData);
        }
    }
}
