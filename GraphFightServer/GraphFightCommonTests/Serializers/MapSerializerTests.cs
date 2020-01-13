using GraphFightCommon;
using GraphFightCommon.Serializers;
using NUnit.Framework;
using System.Collections.Generic;

namespace GraphFightCommonTests.Serializers
{
    [TestFixture]
    public class MapSerializerTests
    {
        [Test]
        public void MapSerializesToJson()
        {
            //2x4 map
            Tile tile = new Tile(1, TileMovementFlags.None);
            List<List<Tile>> tiles = new List<List<Tile>>();
            tiles.Add(new List<Tile> { tile, tile, tile, tile });
            tiles.Add(new List<Tile> { tile, tile, tile, tile });
            Map aMap = new Map(tiles);
            string serialized = MapSerializer.Serialize(aMap);

            string expected = "{\"Width\":2,\"Height\":4,\"Tiles\":[[1,1,1,1],[1,1,1,1]]}";
            Assert.That(serialized, Is.EqualTo(expected));
        }

        [Test]
        public void MapDeserializesFromJson()
        {
            Tile tile1 = new Tile(1, TileMovementFlags.BulletPassable);
            List<Tile> tiles = new List<Tile> { tile1 };
            string source = "{\"Width\":2,\"Height\":4,\"Tiles\":[[1,1,1,1],[1,1,1,1]]}";

            Map map = MapSerializer.Deserialize(source, tiles);

            Assert.That(map.Width, Is.EqualTo(2));
            Assert.That(map.Height, Is.EqualTo(4));
            foreach (Tile[] row in map.Tiles)
            {
                foreach (Tile t in row)
                {
                    Assert.That(t, Is.EqualTo(tile1));
                }
            }
        }
    }
}
