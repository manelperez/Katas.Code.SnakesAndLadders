using SnakesAndLadders.Domain.Interfaces;

namespace SnakesAndLadders.Domain
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