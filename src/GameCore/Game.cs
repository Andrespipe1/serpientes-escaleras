namespace GameCore;

public class Game
{
    public Player Player { get; }
    public Board Board { get; }
    public IDice Dice { get; }
    public GameStatus Status { get; private set; }

    public Game() : this(new RandomDice()) { }

    public Game(IDice dice)
    {
        Player = new Player();
        Board = new Board();
        Dice = dice;
        Status = GameStatus.InProgress;
    }

    public void MovePlayer(int spaces)
    {
        if (Status != GameStatus.InProgress)
            return;

        if (!Board.CanAdvance(Player.Position, spaces))
            return;

        Player.Move(spaces);

        if (Player.Position == Board.TotalSquares)
            Status = GameStatus.Won;
    }

    public int TakeTurn()
    {
        int roll = Dice.Roll();
        MovePlayer(roll);
        return roll;
    }
}
