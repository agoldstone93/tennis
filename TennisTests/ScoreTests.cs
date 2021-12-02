using NUnit.Framework;
using Tennis;

namespace TennisTests
{
    public class ScoreTests
    {
        [Test]
        public void NoPointsScored_ScoreIsLoveAll()
        {
            //arrange
            var server = "P1";
            var receiver = "P2";
            var game = new Game(server, receiver);

            //act
            var result = game.Score();

            //assert
            Assert.AreEqual("Love all", result);
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
            Assert.AreEqual("Fifteen all", score);
        }

        [Test]
        public void TwoPointsToServerThreePointsToReceiever_ScoreIsThirtyForty()
        {
            //arrange
            var server = "Player 1";
            var receiver = "Player 2";
            var game = new Game(server, receiver);

            //act
            game.PointTo(server);
            game.PointTo(server);

            game.PointTo(receiver);
            game.PointTo(receiver);
            game.PointTo(receiver);
            var score = game.Score();

            //assert
            Assert.AreEqual("Thirty, forty", score);
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
            Assert.AreEqual("Deuce", score);
        }

        [Test]
        public void FourPointsToServerThreePointsToReceiever_ScoreIsAdvantage()
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

            game.PointTo(server);

            var score = game.Score();

            //assert
            Assert.AreEqual("Advantage, Player 1", score);
        }

        [Test]
        public void SevenPointsToRecieverFivePointsToServer_ScoreIsGame()
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

            game.PointTo(server);
            game.PointTo(receiver);
            game.PointTo(server);
            game.PointTo(server);

            var score = game.Score();

            //assert
            Assert.AreEqual("Game, Player 1", score);
        }

        [Test]
        public void FourPointsToRecieverZeroPointsToServer_ScoreIsGame()
        {
            //arrange
            var server = "Player 1";
            var receiver = "Player 2";
            var game = new Game(server, receiver);

            //act
            game.PointTo(server);
            game.PointTo(server);
            game.PointTo(server);
            game.PointTo(server);

            var score = game.Score();

            //assert
            Assert.AreEqual("Game, Player 1", score);
        }
    }
}