using SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces;
using SnakesAndLadders.Domain.SnakesAndLaddersAggregate.ValueObjects;

namespace SnakesAndLadders.Domain.SnakesAndLaddersAggregate
{
    public class Game : IGame
    {
        public List<IToken> Tokens { get; set; }

        public DiceRoll Dice { get; set; }

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

        public int DiceRoll()
        {
            Dice = new();
            return Dice.Value;
        }
    }
}
