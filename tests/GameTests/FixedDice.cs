using GameCore;

namespace GameTests;

public class FixedDice : IDice
{
    private readonly int _fixedValue;

    public FixedDice(int fixedValue)
    {
        _fixedValue = fixedValue;
    }

    public int Roll() => _fixedValue;
}
