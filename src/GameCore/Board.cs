namespace GameCore;

public class Board
{
    public const int TotalSquares = 100;

    public bool CanAdvance(int currentPosition, int spaces)
    {
        return currentPosition + spaces <= TotalSquares;
    }
}
