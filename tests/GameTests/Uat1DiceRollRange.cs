using GameCore;

namespace GameTests;

public class Uat1DiceRollRange
{
    [Fact]
    public void DiceRoll_AlwaysBetween1And6()
    {
        var dice = new RandomDice();

        for (int i = 0; i < 100; i++)
        {
            int roll = dice.Roll();
            Assert.InRange(roll, 1, 6);
        }
    }
}
