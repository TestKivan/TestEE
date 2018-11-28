using System;
using Xunit;
using TaskEE;

namespace TaskEETests
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            Game game = new Game();
            Assert.InRange(game.secretNumber, 1, 300);
        }

        [Fact]
        public void CompareLess()
        {
            Game game = new Game();
            game.secretNumber = 5;

            Assert.False(game.Check("4"));
        }

        [Fact]
        public void CompareMore()
        {
            Game game = new Game();
            game.secretNumber = 5;

            Assert.False(game.Check("6"));
        }

        [Fact]
        public void CompareEqual()
        {
            Game game = new Game();
            game.secretNumber = 5;

            Assert.True(game.Check("5"));
        }
    }
}
