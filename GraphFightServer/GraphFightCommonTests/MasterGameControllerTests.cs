using GraphFightCommon;
using NUnit.Framework;

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
    }
}
