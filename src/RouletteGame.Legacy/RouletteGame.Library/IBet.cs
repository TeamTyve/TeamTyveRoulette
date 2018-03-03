namespace RouletteGame.Library
{
    public interface IBet
    {
        uint Amount { get; }
        string PlayerName { get; }

        uint WonAmount(Field field);
    }
}