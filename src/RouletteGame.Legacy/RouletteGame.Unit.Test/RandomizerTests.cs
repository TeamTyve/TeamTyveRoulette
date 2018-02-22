using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
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
