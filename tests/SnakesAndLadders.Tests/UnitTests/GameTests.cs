using SnakesAndLadders.Domain.SnakesAndLaddersAggregate;
using SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces;

namespace SnakesAndLadders.Tests.UnitTests
{
    public class GameTests
    {
        //### US 1 - Token Can Move Across the Board
        //As a player
        //I want to be able to move my token
        //So that I can get closer to the goal    

        //**UAT1**
        //Given the game is started
        //When the token is placed on the board
        //Then the token is on square 1
        [Theory]
        [InlineData(1)]
        public void US_1_UAT1(int expected)
        {
            IGame sut = new Game();
            sut.AddPlayers(1);

            Assert.Equal(expected, sut.Tokens.First().Square);
        }

        //**UAT2**
        //Given the token is on square 1
        //When the token is moved 3 spaces
        //Then the token is on square 4
        [Theory]
        [InlineData(3, 4)]
        public void US_1_UAT2(int input, int expected)
        {
            IToken sut = new Token();
            sut.Move(input);

            Assert.Equal(expected, sut.Square);
        }

        //**UAT3**
        //Given the token is on square 1
        //When the token is moved 3 spaces
        //And then it is moved 4 spaces
        //Then the token is on square 8
        [Theory]
        [InlineData(3, 4, 8)]
        public void US_1_UAT3(int inputMove1, int inputMove2, int expected)
        {
            Token sut = new();
            sut.Move(inputMove1);
            sut.Move(inputMove2);

            Assert.Equal(expected, sut.Square);
        }
    }
}