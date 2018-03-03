namespace RouletteGame.Library
{
    public interface IRandomizer
    {
        uint GetNext(uint lowerbound, uint higherbound);
    }
}