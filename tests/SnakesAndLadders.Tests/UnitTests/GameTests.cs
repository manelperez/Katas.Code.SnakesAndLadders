using SnakesAndLadders.Domain;

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
            Token sut = new();

            Assert.Equal(expected, sut.Square);
        }
    }
}