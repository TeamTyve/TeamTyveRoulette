using NUnit.Framework;
using RouletteGame.Legacy;
using RouletteGame.Library;

namespace RouletteGame.Unit.Test
{
    [TestFixture]
    public class FieldGeneratorTests
    {
        [Test]
        public void FieldGenerator_CreateFields_ReturnsListOf37Fields()
        {
            var uut = new FieldGenerator();
            Assert.That(uut.CreateFields().Count, Is.EqualTo(37));
        }

        [Test]
        public void FieldGenerator_CreateFieldsFirstFieldIsGreen_ReturnsFieldGreen()
        {
            var uut = new FieldGenerator();
            Assert.That(uut.CreateFields()[0].Color, Is.EqualTo(Field.Green));
        }

        [Test]
        public void FieldGenerator_CreateFieldsFirstFieldIs0_ReturnsField0n()
        {
            var uut = new FieldGenerator();
            Assert.That(uut.CreateFields()[0].Number, Is.EqualTo(0));
        }
    }
}
