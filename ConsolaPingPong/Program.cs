// See https://aka.ms/new-console-template for more information
/*
 **
 *
 *
 *
 */
using ConsolaPingPong;

Console.WriteLine("Hello, World!");
Console.WriteLine("Es la misma instancia" + (Game.Instance == Game.Instance));
//Game game = Game.Instance;
Game.Instance.OnPlay();
