using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NSubstitute;
using RouletteGame.Library;

namespace RouletteGame.Unit.Test
{
    [TestFixture]
    public class BetUnitTests
    {
        private IBet bet;
        private IFieldGenerator fieldGenerator; 

        [SetUp]
        public void Init()
        {
            bet = Substitute.For<IBet>();
            
            fieldGenerator = Substitute.For<IFieldGenerator>();
            fieldGenerator.CreateFields().Returns(new List<Field> { new Field(0, color: Field.Green) });
            
        }

        [TestCase((uint) 1)]
        [TestCase((uint)2)]
        [TestCase((uint)8)]
        public void wonAmount_test_fieldbet(uint a)
        {
            var field = fieldGenerator.CreateFields();
            bet = new FieldBet("testbet",a,field.First().Number);
            Assert.That(bet.WonAmount(field.First()),Is.EqualTo(a*36));
        }

        [TestCase((uint)1)]
        [TestCase((uint)2)]
        [TestCase((uint)8)]
        public void wonAmount_test_colorbet(uint a)
        {
            var field = fieldGenerator.CreateFields();
            bet = new ColorBet("testbet", a, field.First().Color);
            Assert.That(bet.WonAmount(field.First()), Is.EqualTo(a * 2));
        }

        [TestCase((uint)1)]
        [TestCase((uint)2)]
        [TestCase((uint)8)]
        public void wonAmount_test_Evenoddbet(uint a)
        {
            var field = fieldGenerator.CreateFields();
            bet = new EvenOddBet("testbet", a, true);
            Assert.That(bet.WonAmount(field.First()), Is.EqualTo(a * 2));
        }

        
    }
}
