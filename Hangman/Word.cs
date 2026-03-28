namespace Hangman;

public class Word
{
    Random random = new();
    private string[] words = {
        "programming",
        "hangman",
        "keyboard",
        "monitor",
        "software",
        "developer",
        "variable",
        "function",
        "database",
        "network"
    };
    private string secretWord;
    private List<char> guessedLetters = new List<char>();
    
    
    public Word()
    {
        secretWord = words[random.Next(words.Length)];
    }

    public bool IsCorrectGuess(char letter)
    {

        return secretWord.Contains(letter);
    }
    public void AddGuess(char letter)
    {
        guessedLetters.Add(letter);
        
    }

    public bool IsWordGuessed()
    {
        foreach (char letter in secretWord)
        {
            if (!guessedLetters.Contains(letter))
            {
                return false; 
            }
        }
        return true; 
    }

    public string DisplayWord()
    {
        string display = "";
        foreach (char letter in secretWord)
        {
            if (guessedLetters.Contains(letter))
                display += letter;
            else
                display += "_ ";

        }

        return display;
    }

}