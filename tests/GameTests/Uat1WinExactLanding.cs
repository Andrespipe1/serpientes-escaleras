using GameCore;

namespace GameTests;

public class Uat1WinExactLanding
{
    [Fact]
    public void Token_MovesFrom97To100_WinsGame()
    {
        var game = new Game();

        game.MovePlayer(96);
        game.MovePlayer(3);

        Assert.Equal(100, game.Player.Position);
        Assert.Equal(GameStatus.Won, game.Status);
    }
}
