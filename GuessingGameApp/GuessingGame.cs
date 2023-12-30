using System.Runtime.CompilerServices;
using GuessingGameLib;


[assembly: InternalsVisibleTo("GuessingGameTests")]


namespace GuessingGameApp;

public class GuessingGame
{
    private enum  GameDifficulty{ Easy=1, Medium=2, Hard=3};

    private void ConfigGame()
    {
        Console.WriteLine("Game Config:[enter selects default option]");

        InputPlayerName(out string PlayerName);
        InputDifficultyLevel(out GameDifficulty Difficulty);
    }

    private static void InputDifficultyLevel(
        out GameDifficulty difficulty)
    {
        string msg1 =
        "The Game has three difficulties." + Util.NL +
        "Diffculty determines how many guesses on each level.";

        string prompt1 = "Type the number to choose:" + Util.NL +
        "Would you like to play on: 1. easy, 2. medium, or 3. hard?" +
        " [default: 1]";

        int _default = 1;

        Console.WriteLine(msg1);
        Console.WriteLine(prompt1);

        difficulty = GameDifficulty.Easy;

        var userInput = Console.ReadLine();

        if (Util.ValidateIntInput(_default, userInput,
            out int selection)) 
        {
            selection = Math.Abs(selection);
            if (0 < selection && selection < 4)
            {
                difficulty = (GameDifficulty)selection;
            }
        }
        Console.WriteLine(Util.NL + $"Difficulty set to, {difficulty}");
    }

    private static void MainMenu()
    {
        // DisplayMainMenu(difficulty);
        // bool quit = false;
        // do
        // {
        //     DisplayMainMenu(Difficulty);
        //     ReceiveMenuSelection();
        //     ProcessMenuSelection();
        // } while (!quit);


    }

    private static void ProcessMenuSelection()
    {
        throw new NotImplementedException();
    }

    private static void ReceiveMenuSelection()
    {
        throw new NotImplementedException();
    }

    private static void DisplayMainMenu(in GameDifficulty difficulty)
    {
        
        string menu = 
            "***************************" + Util.NL +
            "* Guessing Game Main Menu *" + Util.NL +
            "****************************" + Util.NL +
            "* 1. Play Game             *" + Util.NL +
            "* 2. Game Settings         *" + Util.NL +
            "* 3. User Stats            *" + Util.NL +
            "* 4. Quit                  *" + Util.NL +
            "***************************" + Util.NL;
        string difficultyMsg = $"Current Difficulty: {difficulty}";
        // string currentDifficulty = .GameDifficulty.ToString();

        Console.Clear();
        Console.WriteLine(menu);
        Console.WriteLine(difficultyMsg);
    }

    private static void InputPlayerName(out string playerName)
    {
        string _defaultName = "player";
        string prompt1 = "How would you like to be called?";
        string prompt2 = $"What is your name? [default: player]";
        string msg1 = "Your Player Name Set.";
        string msg2 = "Default Player Name Set.";

        Console.WriteLine(Util.NL + prompt1);
        Console.WriteLine(prompt2);

        string? userNameInput = Console.ReadLine();

        if (Util.ValidateStringInput(in _defaultName, in userNameInput,
            out playerName))
        {
            Console.WriteLine(Util.NL + msg1);
        }
        else
        {
            Console.WriteLine(Util.NL + msg2);
        }
        Console.WriteLine($"Name: {playerName}" + Util.NL);
    }

    public void RunGame()
    {
        throw new NotImplementedException();
    }
}
