namespace Hangman;


public class Game
{
    private Word word;
    private int lives;

    public Game()
    {
        
        word = new Word();
        lives = 6;
        
        
    }

    public void Start()
    {
        while (lives > 0 && !word.IsWordGuessed())
        {
            Console.WriteLine(word.DisplayWord());
            Console.WriteLine($"Lives remaining: {lives}");
        
            Console.Write("Guess a letter: ");
            char letter = Console.ReadLine()[0];  // [0] gets first character of input
        
            if (word.IsCorrectGuess(letter))
            {
                Console.WriteLine("Correct!");
                word.AddGuess(letter);
            }
            else
            {
                Console.WriteLine("Wrong!");
                word.AddGuess(letter);
                lives--;
            }
        }

        if (word.IsWordGuessed())
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("You lose!");
        }
    }
}