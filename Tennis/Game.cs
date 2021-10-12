using System;
namespace Tennis
{
    public class Game
    {
        string server;
        string receiver;
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
            else Console.WriteLine("Invalid player name");
            
        }

        public string Score()
        {
            return $"{serverPoints} - {receiverPoints}";
        }
    }
}
