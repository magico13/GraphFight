using GraphFightCommon;
using GraphFightCommon.Serializers;
using NUnit.Framework;
using System.Collections.Generic;

namespace GraphFightCommonTests.Serializers
{
    [TestFixture]
    public class TileSerializationTests
    {
        [Test]
        public void TileSerializesToJson()
        {
            Tile tile = new Tile(123, TileMovementFlags.BulletPassable | TileMovementFlags.Passable);
            string serialized = TileSerializer.Serialize(tile);

            string expected = "{\"MovementFlags\":5,\"Id\":123}";
            Assert.That(serialized, Is.EqualTo(expected));
        }

        [Test]
        public void TileListSerializesToJson()
        {
            Tile tile = new Tile(123, TileMovementFlags.BulletPassable | TileMovementFlags.Passable);
            Tile tile2 = new Tile(127, TileMovementFlags.BulletPassable);
            List<Tile> list = new List<Tile> { tile, tile2 };
            string serialized = TileSerializer.SerializeList(list);

            string expected = "[{\"MovementFlags\":5,\"Id\":123},{\"MovementFlags\":4,\"Id\":127}]";
            Assert.That(serialized, Is.EqualTo(expected));
        }
    }
}
