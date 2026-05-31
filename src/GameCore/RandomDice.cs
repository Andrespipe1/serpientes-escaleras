namespace GameCore;

public class RandomDice : IDice
{
    private readonly Random _random = new();

    public int Roll()
    {
        return _random.Next(1, 7);
    }
}
