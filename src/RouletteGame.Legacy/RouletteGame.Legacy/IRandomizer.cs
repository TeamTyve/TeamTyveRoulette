namespace RouletteGame.Legacy
{
    public interface IRandomizer
    {
        uint GetNext(uint lowerbound, uint higherbound);
    }
}