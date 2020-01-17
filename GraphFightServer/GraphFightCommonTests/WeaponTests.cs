using GraphFightCommon;
using NUnit.Framework;

namespace GraphFightCommonTests
{
    [TestFixture]
    public class WeaponTests
    {
        [Test]
        public void WeaponHasDamageStat()
        {
            Weapon wep = new Weapon(damage: 2);
            Assert.That(wep.Damage, Is.EqualTo(2));
        }

        [Test]
        public void WeaponHasAccuracyStat()
        {
            Weapon wep = new Weapon(accuracy: 0.3);
            Assert.That(wep.Accuracy, Is.EqualTo(0.3));
        }
    }
}
