namespace GameCore;

public class Player
{
    public int Position { get; private set; } = 1;

    public void Move(int spaces)
    {
        Position += spaces;
    }
}
