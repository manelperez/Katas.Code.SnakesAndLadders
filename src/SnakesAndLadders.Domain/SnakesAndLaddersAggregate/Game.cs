using SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces;

namespace SnakesAndLadders.Domain.SnakesAndLaddersAggregate
{
    public class Game : IGame
    {
        public List<IToken> Tokens { get; set; }

        public Game()
        {
            Tokens = new();
        }

        public void AddPlayers(int numberOfPlayers)
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                Tokens.Add(new Token());
            }
        }
    }
}
