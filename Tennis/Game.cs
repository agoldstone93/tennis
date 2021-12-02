using System;
namespace Tennis
{
    public class Game
    {
        readonly private Player server;
        readonly private Player receiver;

        public Game(string serverName, string receiverName)
        {
            server = new Player(serverName, 0);
            receiver = new Player(receiverName, 0);
        }

        public void PointTo(string playerName)
        {
            if (playerName != server.Name && playerName != receiver.Name)
                throw new NullReferenceException("Invalid player name");

            // if game doesnt go to deuce
            if (playerName == server.Name && server.Points == 3 && receiver.Points < 3)
                server.Points = 5;
            else if (playerName == receiver.Name && receiver.Points == 3 && server.Points < 3)
                receiver.Points = 5;
            // if game goes to advantage
            else if (playerName == receiver.Name && server.Points == 4 && receiver.Points == 3)
                server.Points--;
            else if (playerName == server.Name && receiver.Points == 4 && server.Points == 3)
                receiver.Points--;
            // all other points
            else if (playerName == server.Name)
                server.Points++;
            else
                receiver.Points++;
        }

        public string Score()
        {
            var scoreNames = new string[] { "love", "fifteen", "thirty", "forty", "advantage", "game" };

            string result;
            if (server.Points == 3 && receiver.Points == 3)
                result = "deuce";
            // convention is to say e.g. 'fifteen all' rather than 'fifteen, fifteen'
            else if (server.Points == receiver.Points)
                result = $"{scoreNames[server.Points]} all";
            // if game goes to advantage
            else if (server.Points == 4)
                result = $"advantage, {server.Name}";
            else if (receiver.Points == 4)
                result = $"advantage, {receiver.Name}";
            // if player wins game
            else if (server.Points == 5)
                result = $"game, {server.Name}";
            else if (receiver.Points == 5)
                result = $"game, {server.Name}";
            else
                result = $"{scoreNames[server.Points]}, {scoreNames[receiver.Points]}";

            return CapitaliseSentence(result);
        }

        private static string CapitaliseSentence(string input)
        {
            return char.ToUpper(input[0]) + input[1..];
        }
    }
}
