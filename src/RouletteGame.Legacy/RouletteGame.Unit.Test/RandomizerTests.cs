using NUnit.Framework;
using Randomizer = RouletteGame.Legacy.Randomizer;

namespace RouletteGame.Unit.Test
{
    [TestFixture()]
    public class RandomizerTests
    {
        [Test]
        public void Randomizer_ReturnsValue()
        {
            var uut = new Randomizer();
            Assert.That(uut.GetNext(0,37), Is.GreaterThanOrEqualTo((uint)0));
        }
    }
}
