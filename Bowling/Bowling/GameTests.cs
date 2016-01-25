﻿using System.Linq;
using NUnit.Framework;

namespace Bowling
{
    [TestFixture]
    public class GameTests
    {
        [Test]
        public void Game_with_no_score()
        {
            var game = new Game();
            for (var i = 1; i <= 21; i++)
                game.Roll(0);

            Assert.AreEqual(0, game.Score());
        }

        [Test]
        public void Game_with_all_Ones()
        {
            var game = new Game();
            for (var i = 1; i <= 20; i++)
                game.Roll(1);

            Assert.AreEqual(20, game.Score());
        }

        [Test]
        public void Game_with_a_Spare()
        {
            var game = new Game();
            game.Roll(9);
            game.Roll(1);
            game.Roll(5);
            for (var i = 4; i <= 20; i++)
                game.Roll(0);

            Assert.AreEqual(20, game.Score());
        }
    }

    public class Game
    {
        private readonly int[] _rolls;
        private int _currentRoll;

        public Game()
        {
            _currentRoll = 0;
            _rolls = new int[21];
        }

        public void Roll(int pins)
        {
            _rolls[_currentRoll++] = pins;
        }

        public int Score()
        {
            var score = _rolls.Sum();

            return score;
        }
    }
}