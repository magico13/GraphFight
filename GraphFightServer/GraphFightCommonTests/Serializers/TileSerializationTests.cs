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

        [Test]
        public void JsonDeserializesToTile()
        {
            string source = "{\"MovementFlags\":5,\"Id\":123}";
            Tile tile = TileSerializer.Deserialize(source);

            Assert.That(tile.Id, Is.EqualTo(123));
            Assert.That(tile.MovementFlags, Is.EqualTo(TileMovementFlags.BulletPassable | TileMovementFlags.Passable));
        }

        [Test]
        public void JsonDeserializesToTileList()
        {
            string source = "[{\"MovementFlags\":5,\"Id\":123},{\"MovementFlags\":4,\"Id\":127}]";
            List<Tile> tiles = TileSerializer.DeserializeList(source);

            Assert.That(tiles, Has.Count.EqualTo(2));
            Assert.That(tiles[0].Id, Is.EqualTo(123));
            Assert.That(tiles[0].MovementFlags, Is.EqualTo(TileMovementFlags.BulletPassable | TileMovementFlags.Passable));
            Assert.That(tiles[1].Id, Is.EqualTo(127));
            Assert.That(tiles[1].MovementFlags, Is.EqualTo(TileMovementFlags.BulletPassable));
        }
    }
}
