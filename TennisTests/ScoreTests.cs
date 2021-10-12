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
            Assert.AreEqual(result, "0 - 0");
        }

        [Test]
        public void OnePointEach_ScoreIsFifteenAll()
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
            Assert.AreEqual(score, "1 - 1");
        }
    }
}