using System;

namespace RouletteGame.Legacy
{
    public class Randomizer : IRandomizer
    {
        public uint GetNext(uint lowerbound, uint higherbound)
        {
            return (uint) new Random().Next((int)lowerbound, (int)higherbound);
        }
    }
}