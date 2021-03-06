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

        [Test]
        public void Game_with_a_Strike()
        {
            var game = new Game();
            game.Roll(10);
            game.Roll(1);
            game.Roll(5);
            for (var i = 5; i <= 20; i++)
                game.Roll(0);

            Assert.AreEqual(22, game.Score());
        }

        [Test]
        public void Perfect_game()
        {
            var game = new Game();
            for (var i = 1; i <= 12; i++)
                game.Roll(10);

            Assert.AreEqual(300, game.Score());
        }
    }

    public class Game
    {
        private readonly int[] _rolls;
        private int _currentRoll;

        public Game()
        {
            _currentRoll = 0;
            _rolls = new int[22];
        }

        public void Roll(int pins)
        {
            _rolls[_currentRoll++] = pins;
        }


        public int Score()
        {
            var score = 0;

            var rollIndex = 0;
            for (var frameIndex = 0; frameIndex < 10; frameIndex++)
            {
                if (IsStrike(rollIndex))
                {
                    score += 10 + StrikeBonus(rollIndex);
                    rollIndex++;
                }
                else if (IsSpare(rollIndex))
                {
                    score += 10 + SpareBonus(rollIndex);
                    rollIndex += 2;
                }
                else
                {
                    score += FrameScore(rollIndex);
                    rollIndex += 2;
                }
            }

            return score;
        }

        private int FrameScore(int rollIndex)
        {
            return _rolls[rollIndex] + _rolls[rollIndex + 1];
        }

        private int SpareBonus(int rollIndex)
        {
            return _rolls[rollIndex + 2];
        }
        private int StrikeBonus(int rollIndex)
        {
            return _rolls[rollIndex + 1] + _rolls[rollIndex + 2];
        }

        private bool IsSpare(int rollIndex)
        {
            return FrameScore(rollIndex) == 10;
        }

        private bool IsStrike(int rollIndex)
        {
            return _rolls[rollIndex] == 10;
        }
    }
}
