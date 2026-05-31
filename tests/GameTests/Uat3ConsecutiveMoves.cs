using GameCore;

namespace GameTests;

public class Uat3ConsecutiveMoves
{
    [Fact]
    public void Token_Moves3Then4Spaces_EndsAt8()
    {
        var game = new Game();

        game.MovePlayer(3);
        game.MovePlayer(4);

        Assert.Equal(8, game.Player.Position);
    }
}
