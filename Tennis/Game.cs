using System;
namespace Tennis
{
    public class Game
    {
        readonly string server;
        readonly string receiver;
        int serverPoints = 0;
        int receiverPoints = 0;
        

        public Game(string server, string receiver)
        {
            this.server = server;
            this.receiver = receiver;
        }

        public void PointTo(string player)
        {
            if (player != server && player != receiver)
                throw new NullReferenceException("Invalid player name");

            if (player == server && serverPoints == 3 && receiverPoints < 3)
                serverPoints = 5;
            else if (player == receiver && receiverPoints == 3 && serverPoints < 3)
                receiverPoints = 5;
            else if (player == receiver && serverPoints == 4 && receiverPoints == 3)
                serverPoints--;
            else if (player == server && receiverPoints == 4 && serverPoints == 3)
                receiverPoints--;
            else if (player == server)
                serverPoints++;
            else
                receiverPoints++;
        }

        public string Score()
        {
            var scoreNames = new string[] { "love", "fifteen", "thirty", "forty", "advantage", "game" };

            string result;
            if (serverPoints == 3 && receiverPoints == 3)
                result = "deuce";
            else if (serverPoints == receiverPoints)
                result = $"{scoreNames[serverPoints]} all";
            else if (serverPoints == 4)
                result = $"advantage, {server}";
            else if (receiverPoints == 4)
                result = $"advantage, {receiver}";
            else if (serverPoints == 5)
                result = $"game, {server}";
            else if (receiverPoints == 5)
                result = $"game, {server}";
            else
                result = $"{scoreNames[serverPoints]}, {scoreNames[receiverPoints]}";

            return CapitaliseSentence(result);
        }

        private static string CapitaliseSentence(string input)
        {
            return char.ToUpper(input[0]) + input[1..];
        }
    }
}
