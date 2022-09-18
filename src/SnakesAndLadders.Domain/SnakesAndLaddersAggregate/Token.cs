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

        public void Move(int spaces)
        {
            int currentSquare = Square;
            Square += spaces;
            if (Square > 100)
            {
                Square = currentSquare;
            }
        }
    }
}