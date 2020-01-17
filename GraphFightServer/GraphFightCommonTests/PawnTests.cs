using GraphFightCommon;
using NUnit.Framework;

namespace GraphFightCommonTests
{
    [TestFixture]
    public class PawnTests
    {
        [Test]
        public void PawnHasHealth()
        {
            Pawn pawn = new Pawn(null, health: 3);
            Assert.That(pawn.MaxHealth, Is.EqualTo(3));
            Assert.That(pawn.Health, Is.EqualTo(3));
        }

        [Test]
        public void PawnHasMovement()
        {
            Pawn pawn = new Pawn(null, move: 2);
            Assert.That(pawn.MaxMovement, Is.EqualTo(2));
            Assert.That(pawn.Movement, Is.EqualTo(2));
        }

        [Test]
        public void PawnHasWeapon()
        {
            Pawn pawn = new Pawn(weapon: new Weapon(2, 0.2));
            Assert.That(pawn.Weapon, Is.Not.Null);
            Assert.That(pawn.Weapon.Damage, Is.EqualTo(2));
            Assert.That(pawn.Weapon.Accuracy, Is.EqualTo(0.2));
        }

        [Test]
        public void PawnHasPosition()
        {
            Pawn pawn = new Pawn(null)
            {
                PosX = 5,
                PosY = 2
            };

            Assert.That(pawn.PosX, Is.EqualTo(5));
            Assert.That(pawn.PosY, Is.EqualTo(2));
        }
    }
}
