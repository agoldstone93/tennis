using System;

namespace Tennis
{
    class Program
    {
        static void Main(string[] args)
        {
            //How to Play

            //1.Create two players, by creating two string variables with their names
            //E.g.:
            var server = "P1";
            var receiver = "P2";

            //2.Create a game object:
            //E.g.:
            var game = new Game(server, receiver);

            //3.Award points to players using the 'PointTo' method:
            game.PointTo(server);
            game.PointTo(receiver);
            game.PointTo(server);

            //4.If you'd like to see the score, you can use the 'Score' method and write it to the console:
            Console.WriteLine(game.Score());
        }
    }
}
