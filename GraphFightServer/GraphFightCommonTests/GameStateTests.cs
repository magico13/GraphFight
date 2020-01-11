using GraphFightCommon;
using NUnit.Framework;

namespace GraphFightCommonTests
{
    [TestFixture]
    public class GameStateTests
    {
        [Test]
        public void CanSetMapOnGameState()
        {
            int width = 1;
            int height = 2;
            GameState game = new GameState();
            game.Map = new Map(width, height);
            Assert.That(game.Map, Is.Not.Null);
            Assert.That(game.Map.Width, Is.EqualTo(width));
            Assert.That(game.Map.Height, Is.EqualTo(height));
        }
    }
}
