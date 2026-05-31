using GameCore;

namespace GameTests;

public class Uat2WinOvershootStays
{
    [Fact]
    public void Token_MovesFrom97To101_StaysAt97AndNotWon()
    {
        var game = new Game();

        game.MovePlayer(96);
        game.MovePlayer(4);

        Assert.Equal(97, game.Player.Position);
        Assert.Equal(GameStatus.InProgress, game.Status);
    }
}
