using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using RouletteGame.Legacy;

namespace RouletteGame.Unit.Test
{
    [TestFixture]
    class RouletteUnitTests
    {
        private Roulette uut;
        private IRandomizer randomizer;
        private IFieldGenerator fieldGenerator;

        [SetUp]
        public void Init()
        {
            randomizer = Substitute.For<IRandomizer>();
            fieldGenerator = Substitute.For<IFieldGenerator>();

            randomizer.GetNext(0, 1).Returns((uint)0);
            fieldGenerator.CreateFields().Returns(new List<Field> { new Field(0, color: Field.Green) });

            uut = new Roulette(fieldGenerator, randomizer);
        }

        [Test]
        public void Roulette_CanSpin_ReturnsResultIsZero()
        {
            uut.Spin();
            Assert.That(uut.GetResult().Number, Is.EqualTo(0));
            Assert.That(uut.GetResult().Color, Is.EqualTo(Field.Green));
        }

        [TestCase((uint)0, (uint)0)]
        [TestCase((uint)1, (uint)1)]
        [TestCase((uint)37, (uint)37)]
        public void Roulettte_SetLowerBounds_ReturnsValues(uint a, uint e)
        {
            uut.Lowerbound = a;
            Assert.That(uut.Lowerbound, Is.EqualTo((uint)e));
        }

        [TestCase((uint)0, (uint)0)]
        [TestCase((uint)1, (uint)1)]
        [TestCase((uint)37, (uint)37)]
        public void Roulettte_SetHigherBounds_ReturnsValues(uint a, uint e)
        {
            uut.Higherbound = a;
            Assert.That(uut.Higherbound, Is.EqualTo((uint)e));
        }

    }
}
