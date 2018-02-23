using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RouletteGame.Legacy;

namespace RouletteGame.Unit.Test
{
    [TestFixture]
    class RouletteGameUnitTests
    {
        private Legacy.RouletteGame uut;
        private IBet bet;
        private IRoulette roulette;

        [Test]
        public void Roulette_CanCloseBets_ResultIsException()
        {
            uut.CloseBets();
            var ex = Assert.Throws<RouletteGameException>(
                () => uut.PlaceBet(new ColorBet("Player 1", 100, Field.Black)));
            Assert.That(ex.Message, Is.EqualTo("Bet placed while round closed"));
        }

        [Test]
        public void Roulette_CanOpenBets_ResultIsExceptionNotThrown()
        {
            uut.OpenBets();
            Assert.DoesNotThrow(() => uut.PlaceBet(new ColorBet("Player 1", 100, Field.Black)));
        }

        [Test]
        public void Roulette_CanPayUp_ResultIsPlayerWon()
        {
            Assert.That(i
        }

    }
}
