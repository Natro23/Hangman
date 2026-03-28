namespace Hangman;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Hangman!");
        Game game = new Game();
        game.Start();
    }
}