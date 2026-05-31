using GameCore;

namespace GameTests;

public class Uat1TokenStartsAtPosition1
{
    [Fact]
    public void Token_StartsAtPosition1()
    {
        var game = new Game();

        int position = game.Player.Position;

        Assert.Equal(1, position);
    }
}
