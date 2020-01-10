using GraphFightCommon;
using NUnit.Framework;

namespace GraphFightCommonTests
{
    public class TileTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TileDefaultsToFullyBlocking()
        {
            Tile tile = new Tile();
            Assert.That(tile.IsPassable, Is.False);
            Assert.That(tile.IsStandable, Is.False);
            Assert.That(tile.IsBulletPassable, Is.False);
        }

        [Test]
        public void NoneIsFullyBlocking()
        {
            Tile tile = new Tile(TileMovementFlags.None);
            Assert.That(tile.IsPassable, Is.False);
            Assert.That(tile.IsStandable, Is.False);
            Assert.That(tile.IsBulletPassable, Is.False);
        }

        [Test]
        public void CanSetTileToPassable()
        {
            Tile tile = new Tile(TileMovementFlags.Passable);
            Assert.That(tile.IsPassable, Is.True);
            Assert.That(tile.IsStandable, Is.False);
            Assert.That(tile.IsBulletPassable, Is.False);
        }

        [Test]
        public void CanSetTileToStandable()
        {
            Tile tile = new Tile(TileMovementFlags.Standable);
            Assert.That(tile.IsPassable, Is.False);
            Assert.That(tile.IsStandable, Is.True);
            Assert.That(tile.IsBulletPassable, Is.False);
        }

        [Test]
        public void CanSetTileToBulletPassable()
        {
            Tile tile = new Tile(TileMovementFlags.BulletPassable);
            Assert.That(tile.IsPassable, Is.False);
            Assert.That(tile.IsStandable, Is.False);
            Assert.That(tile.IsBulletPassable, Is.True);
        }

        [Test]
        public void CanSetTwoMovementFlags()
        {
            Tile tile = new Tile(TileMovementFlags.Passable | TileMovementFlags.BulletPassable);
            Assert.That(tile.IsPassable, Is.True);
            Assert.That(tile.IsStandable, Is.False);
            Assert.That(tile.IsBulletPassable, Is.True);
        }

        [Test]
        public void CanSetThreeMovementFlags()
        {
            Tile tile = new Tile(TileMovementFlags.Passable | TileMovementFlags.BulletPassable | TileMovementFlags.Standable);
            Assert.That(tile.IsPassable, Is.True);
            Assert.That(tile.IsStandable, Is.True);
            Assert.That(tile.IsBulletPassable, Is.True);
        }
    }
}