using NUnit.Framework;
using Tennis;

namespace TennisTests
{
    public class ScoreTests
    {
        [Test]
        public void NoPointsScored_ScoreIsLoveLove()
        {
            //arrange
            var server = "P1";
            var receiver = "P2";
            var game = new Game(server, receiver);

            //act
            var result = game.Score();

            //assert
            Assert.AreEqual(result, "Love, love");
        }

        [Test]
        public void OnePointEach_ScoreIsFifteenFifteen()
        {
            //arrange
            var server = "Player 1";
            var receiver = "Player 2";
            var game = new Game(server, receiver);

            //act
            game.PointTo(server);
            game.PointTo(receiver);
            var score = game.Score();

            //assert
            Assert.AreEqual(score, "Fifteen, fifteen");
        }

        [Test]
        public void ThreePointsEach_ScoreIsDeuce()
        {
            //arrange
            var server = "Player 1";
            var receiver = "Player 2";
            var game = new Game(server, receiver);

            //act
            game.PointTo(server);
            game.PointTo(server);
            game.PointTo(server);
            game.PointTo(receiver);
            game.PointTo(receiver);
            game.PointTo(receiver);
            var score = game.Score();

            //assert
            Assert.AreEqual(score, "Deuce");
        }
    }
}