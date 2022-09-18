using SnakesAndLadders.ConsoleApp.Interfaces;

namespace SnakesAndLadders.ConsoleApp
{
    public class View : IView
    {
        public string ReadKey()
        {
            return Console.ReadKey().ToString() ?? string.Empty;
        }

        public string ReadLine()
        {
            return Console.ReadLine() ?? string.Empty;
        }

        public void Write(string output)
        {
            Console.Write(output);
        }

        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }
        public void LineFeed()
        {
            Console.WriteLine(string.Empty);
        }
    }
}
