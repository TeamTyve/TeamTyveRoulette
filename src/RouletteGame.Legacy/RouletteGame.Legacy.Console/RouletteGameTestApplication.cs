﻿using RouletteGame.Library;

namespace RouletteGame.Legacy.Console
{
    internal class RouletteGameTestApplication
    {
        private static void Main()
        {
            var game = new Library.RouletteGame(new Roulette(new FieldGenerator(), new Randomizer()));
            game.OpenBets();
            game.PlaceBet(new ColorBet("Player 1", 100, Field.Black));
            game.PlaceBet(new ColorBet("Player 1", 100, Field.Red));

            game.PlaceBet(new EvenOddBet("Player 2", 100, true));
            game.PlaceBet(new EvenOddBet("Player 2", 100, false));

            for (uint i = 0; i < 36; i++)
                game.PlaceBet(new FieldBet("Player 3", 100, i));

            game.CloseBets();
            game.SpinRoulette();
            game.PayUp();
        }
    }
}