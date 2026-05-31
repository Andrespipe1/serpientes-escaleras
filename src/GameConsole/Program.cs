using GameCore;

var game = new Game();
game.TakeTurn();
Console.WriteLine($"Token en casilla {game.Player.Position} después de la tirada");
