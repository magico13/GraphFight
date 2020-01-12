using GraphFightCommon;
using GraphFightCommon.Loaders;
using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace GraphFightCommonTests.Loaders
{
    [TestFixture]
    public class TileLoaderTests
    {
        [Test]
        public void LoadsTilesFromTestFile()
        {
            List<Tile> tiles = TileLoader.Load(Path.Combine(TestContext.CurrentContext.WorkDirectory, "./TestFiles/Tiles.json"));
            Assert.That(tiles, Is.Not.Null);
            Assert.That(tiles, Has.Count.EqualTo(3));
            Assert.That(tiles[0].Id, Is.EqualTo(1));
            Assert.That(tiles[0].MovementFlags, Is.EqualTo(TileMovementFlags.BulletPassable | 
                                                           TileMovementFlags.Passable | 
                                                           TileMovementFlags.Standable));

            Assert.That(tiles[1].Id, Is.EqualTo(5));
            Assert.That(tiles[1].MovementFlags, Is.EqualTo(TileMovementFlags.BulletPassable));

            Assert.That(tiles[2].Id, Is.EqualTo(13));
            Assert.That(tiles[2].MovementFlags, Is.EqualTo(TileMovementFlags.None));
        }
    }
}
