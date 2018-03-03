namespace RouletteGame.Library
{
    public interface IRoulette
    {
        Field GetResult();
        void Spin();
    }
}