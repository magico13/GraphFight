using GraphFightCommon;
using NUnit.Framework;
using System.Collections.Generic;

namespace GraphFightCommonTests
{
    [TestFixture]
    public class MasterGameControllerTests
    {
        [Test]
        public void MGCHasGameStateDefined()
        {
            Assert.That(MasterGameController.TheGame, Is.Not.Null);
        }

        [Test]
        public void MGCHasMap()
        {
            MasterGameController.TheGame.Map = new Map();
            Assert.That(MasterGameController.TheGame.Map, Is.Not.Null);
        }

        [Test]
        public void MGCHasTileList()
        {
            MasterGameController.TheGame.Tiles = new List<Tile>();
            Assert.That(MasterGameController.TheGame.Tiles, Is.Not.Null);
        }
    }
}
