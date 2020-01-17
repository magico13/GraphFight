using GraphFightCommon;
using NUnit.Framework;
using System.Collections.Generic;

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

        [Test]
        public void CanSetTeams()
        {
            List<Pawn> team1 = new List<Pawn>
            {
                new Pawn(null, 1),
                new Pawn(null, 2)
            };

            List<Pawn> team2 = new List<Pawn>
            {
                new Pawn(null, 3)
            };

            GameState game = new GameState();
            game.Teams = new List<List<Pawn>>
            {
                team1,
                team2
            };

            Assert.That(game.Teams, Has.Count.EqualTo(2));
            Assert.That(game.Teams[0], Has.Count.EqualTo(2));
            Assert.That(game.Teams[0][0].Health, Is.EqualTo(1));
            Assert.That(game.Teams[0][1].Health, Is.EqualTo(2));

            Assert.That(game.Teams[1], Has.Count.EqualTo(1));
            Assert.That(game.Teams[1][0].Health, Is.EqualTo(3));
        }
    }
}
