using NSubstitute;
using NUnit.Framework;
using RouletteGame.Legacy;


namespace RouletteGame.Unit.Test
{
    [TestFixture]
    class RouletteGameUnitTests
    {
        private Legacy.RouletteGame uut;
        private IRoulette roulette;


        [SetUp]
        public void Init()
        {
            roulette = Substitute.For<IRoulette>();

            uut = new Legacy.RouletteGame(roulette);
        }

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

       /* [Test]
        public void Roulette_CanPayUp_ResultIsPlayerWon()
        {
            uut.OpenBets();
            uut.PlaceBet(bet);
            uut.CloseBets();
            uut.SpinRoulette();
            uut.PayUp();

           // bet.Received().WonAmount();
        }*/

        [Test]
        public void Roulette_CanSpinRoulette_ResultIsSpin()
        {
            uut.OpenBets();
            uut.CloseBets();
            uut.SpinRoulette();

            roulette.Received().Spin();
        }


    }
}
