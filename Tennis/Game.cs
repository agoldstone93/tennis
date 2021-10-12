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
            if (player == server)
                serverPoints++;
            else if (player == receiver)
                receiverPoints++;
            else
                throw new NullReferenceException("Invalid player name");
            
        }

        public string Score()
        {
            var scoreNames = new string[] { "love", "fifteen", "thirty", "forty" };

            string result;
            if (serverPoints == 3 && receiverPoints == 3)
                result = "deuce";
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
