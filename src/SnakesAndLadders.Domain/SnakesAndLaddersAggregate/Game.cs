using SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces;
using SnakesAndLadders.Domain.SnakesAndLaddersAggregate.ValueObjects;

namespace SnakesAndLadders.Domain.SnakesAndLaddersAggregate
{
    public class Game : IGame
    {
        public List<IToken> Tokens { get; set; }
        public DiceRoll Dice { get; set; }
        public int CurrentPlayer { get; set; }
        public bool HasWinner
        {
            get
            {
                return Tokens.Exists(t => t.Winner);
            }
        }

        public Game()
        {
            CurrentPlayer = 1;
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

        public void NextPlayer()
        {
            if (CurrentPlayer == Tokens.Count)
            {
                CurrentPlayer = 1;
            }
            else
            {
                CurrentPlayer++;
            }
        }
    }
}
