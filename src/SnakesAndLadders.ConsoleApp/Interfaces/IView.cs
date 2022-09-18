namespace SnakesAndLadders.ConsoleApp.Interfaces
{
    public interface IView
    {
        string ReadKey();
        string ReadLine();
        void Write(string output);
        void WriteLine(string output);
        void LineFeed();
    }
}
