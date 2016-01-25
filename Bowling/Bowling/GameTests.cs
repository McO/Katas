using NUnit.Framework;

namespace Bowling
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void LoserGame()
        {
            var game = new Game();
            for (var i = 1; i <= 21; i++)
                game.Roll(0);

            Assert.AreEqual(0, game.Score());
        }
    }

    public class Game
    {
        private int _score;

        public void Roll(int pins)
        {
            _score += pins;
        }

        public int Score()
        {
            return _score;
        }
    }
}
