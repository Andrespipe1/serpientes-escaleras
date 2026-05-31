using GameCore;

var game = new Game(new RandomDice());

Console.WriteLine("=== SERPIENTES Y ESCALERAS ===");
Console.WriteLine("Presiona Enter para tirar el dado...");
Console.WriteLine();

while (game.Status == GameStatus.InProgress)
{
    Console.ReadLine();

    int roll = game.TakeTurn();

    Console.WriteLine($"  Sacaste {roll} → Casilla {game.Player.Position}");

    if (game.Status == GameStatus.Won)
    {
        Console.WriteLine();
        Console.WriteLine("  ¡Felicidades! ¡Has llegado a la casilla 100 y ganaste el juego!");
    }
}
