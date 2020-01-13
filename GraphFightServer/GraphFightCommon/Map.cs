using System.Collections.Generic;
using System.Linq;

namespace GraphFightCommon
{
    public class Map
    {
        public int Width { get; }
        public int Height { get; }
        public Tile[][] Tiles { get; } = new Tile[][] { };

        public Map() { }
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            Tiles = new Tile[width][];
            for (int i=0; i<width; i++)
            {
                Tiles[i] = new Tile[height];
            }
        }

        public Map(IEnumerable<IEnumerable<Tile>> mapDef)
        {
            int width = mapDef.Count();
            int height = mapDef.First().Count();
            Width = width;
            Height = height;
            Tiles = new Tile[width][];
            for (int i = 0; i < width; i++)
            {
                Tiles[i] = new Tile[height];
                for (int j = 0; j < height; j++)
                {
                    Tiles[i][j] = mapDef.ElementAt(i).ElementAt(j);
                }
            }
        }

    }
}
