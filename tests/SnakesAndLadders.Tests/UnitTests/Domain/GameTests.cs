using SnakesAndLadders.Domain.SnakesAndLaddersAggregate;
using SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces;

namespace SnakesAndLadders.Tests.UnitTests.Domain
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
            IToken sut = new Token();
            sut.Move(inputMove1);
            sut.Move(inputMove2);

            Assert.Equal(expected, sut.Square);
        }

        //### US 2 - Player Can Win the Game
        //As a player
        //I want to be able to win the game
        //So that I can gloat to everyone around

        //**UAT1**
        //Given the token is on square 97
        //When the token is moved 3 spaces
        //Then the token is on square 100
        //And the player has won the game
        [Theory]
        [InlineData(97, 3, 100, true)]
        public void US_2_UAT1(int inputSquare, int inputSpaces, int expectedSquare, bool expectedWinner)
        {
            IToken sut = new Token
            {
                Square = inputSquare
            };
            sut.Move(inputSpaces);

            Assert.Equal(expectedSquare, sut.Square);
            Assert.Equal(expectedWinner, sut.Winner);
        }

        //** UAT2**
        //Given the token is on square 97
        //When the token is moved 4 spaces
        //Then the token is on square 97
        //And the player has not won the game
        [Theory]
        [InlineData(97, 4, 97, false)]
        public void US_2_UAT2(int inputSquare, int inputSpaces, int expectedSquare, bool expectedWinner)
        {
            IToken sut = new Token
            {
                Square = inputSquare
            };
            sut.Move(inputSpaces);

            Assert.Equal(expectedSquare, sut.Square);
            Assert.Equal(expectedWinner, sut.Winner);
        }

        //### US 3 - Moves Are Determined By Dice Rolls
        //As a player
        //I want to move my token based on the roll of a die
        //So that there is an element of chance in the game

        //**UAT1**
        //Given the game is started
        //When the player rolls a die
        //Then the result should be between 1-6 inclusive
        [Theory]
        [InlineData(1, 6)]
        public void US_3_UAT1(int low, int high)
        {
            IGame sut = new Game();
            sut.DiceRoll();

            Assert.InRange(sut.Dice.Value, low, high);
        }

        //** UAT2**
        //Given the player rolls a 4
        //When they move their token
        //Then the token should move 4 spaces
        [Theory]
        [InlineData(10)]
        public void US_3_UAT2(int input)
        {
            IGame sut = new Game();
            sut.AddPlayers(1);
            sut.Tokens.First().Square = input;
            sut.DiceRoll();
            sut.Tokens.First().Move(sut.Dice.Value);

            Assert.Equal(input + sut.Dice.Value, sut.Tokens.First().Square);
        }
    }
}