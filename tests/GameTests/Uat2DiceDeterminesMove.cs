using GameCore;

namespace GameTests;

public class Uat2DiceDeterminesMove
{
    [Fact]
    public void FixedDiceRoll4_Moves4Spaces()
    {
        var fixedDice = new FixedDice(4);
        var game = new Game(fixedDice);

        game.TakeTurn();

        Assert.Equal(5, game.Player.Position);
    }
}
