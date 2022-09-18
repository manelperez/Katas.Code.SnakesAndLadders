using SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces;

namespace SnakesAndLadders.Domain.SnakesAndLaddersAggregate
{
    public class Token : IToken
    {
        public int Square { get; set; }

        public Token()
        {
            Square = 1;
        }
    }
}