using GraphFightCommon;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphFightCommonTests
{
    [TestFixture]
    public class PawnTests
    {
        [Test]
        public void PawnHasHealth()
        {
            Pawn pawn = new Pawn(health: 3);
            Assert.That(pawn.MaxHealth, Is.EqualTo(3));
            Assert.That(pawn.Health, Is.EqualTo(3));
        }

        [Test]
        public void PawnHasMovement()
        {
            Pawn pawn = new Pawn(move: 2);
            Assert.That(pawn.MaxMovement, Is.EqualTo(2));
            Assert.That(pawn.Movement, Is.EqualTo(2));
        }
    }
}
