using SnakesAndLadders.Domain.SnakesAndLaddersAggregate.Interfaces;

namespace SnakesAndLadders.Domain.SnakesAndLaddersAggregate
{
    public class Token : IToken
    {
        public int Square { get; set; }

        public bool Winner
        {
            get
            {
                return Square.Equals(100);
            }
        }

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