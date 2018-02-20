using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace RouletteGame.Unit.Test
{
    [TestFixture]
    class FieldUnitTests
    {
        [Test]

        public void Add()
        {
            Assert.That(2+2, Is.EqualTo(4));
        }
    }
}

