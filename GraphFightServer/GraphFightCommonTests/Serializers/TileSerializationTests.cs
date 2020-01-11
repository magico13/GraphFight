using GraphFightCommon;
using GraphFightCommon.Serializers;
using NUnit.Framework;

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

            string expected = "{\"Id\":123,\"MovementFlags\":5}";
            Assert.That(serialized, Is.EqualTo(expected));
        }
    }
}
