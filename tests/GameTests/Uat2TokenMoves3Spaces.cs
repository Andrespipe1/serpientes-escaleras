using GameCore;

namespace GameTests;

public class Uat2TokenMoves3Spaces
{
    [Fact]
    public void Token_Moves3SpacesFromPosition1()
    {
        var game = new Game();

        game.MovePlayer(3);

        Assert.Equal(4, game.Player.Position);
    }
}
