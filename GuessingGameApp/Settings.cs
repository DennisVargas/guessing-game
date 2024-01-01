using GuessingGameLib;

namespace GuessingGameApp;

public class Settings
{
    internal enum  Difficulty{ Easy=1, Medium=2, Hard=3};
    internal string name {get; set;}
    internal Difficulty difficulty {get; set;}

    internal Settings(string name, Difficulty difficulty){
        this.difficulty = difficulty;
        this.name = name;
    }
    internal Settings (){
        this.Config(out string name, out Difficulty difficulty);
        this.name = name;
        this.difficulty = difficulty;
    }

    internal void Config(
        out string name, out Difficulty difficulty){
        string defaultMsg = 
        "Guessing Game - Config:"+Util.NL+
        "[enter selects default option]"+Util.NL;

        Util.ClearScreenPrintMessage(defaultMsg);
        InputPlayerName(out name);
        this.name = name;
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();
        
        Util.ClearScreenPrintMessage(defaultMsg);
        InputDifficultyLevel(out difficulty);
        this.difficulty = difficulty;
        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();

        string? settingString = this.ToString();
        Util.ClearScreenPrintMessage(settingString);

        Console.WriteLine("Press any key to continue...");
        Console.ReadLine();
    }


    public override string ToString()
    {
        string toString = 
            $"Player Name: {this.name}"+Util.NL+
            $"Difficulty Level: {this.difficulty}";
        return toString;
    }
    private static void InputDifficultyLevel(
        out Settings.Difficulty difficulty){
        string msg1 =
        "Difficulty determines how many guesses on each level.";

        string prompt1 = 
        Util.NL + "Choose the number of the difficulty: "+
        Util.NL + "1. Easy [default]"+
        Util.NL + "2. Medium"+
        Util.NL + "3. Hard"+Util.NL+
        "Select a number [press return/enter key for default]: ";

        int _default = 1;

        Console.WriteLine(msg1);
        Console.WriteLine(prompt1);

        difficulty = Settings.Difficulty.Easy;

        var userInput = Console.ReadLine();

        if (Util.ValidateIntInput(_default, userInput,
            out int selection)) 
        {
            selection = Math.Abs(selection);
            if (0 < selection && selection < 4)
            {
                difficulty = (Settings.Difficulty)selection;
            }
        }
        Console.WriteLine(Util.NL + $"Difficulty set to, {difficulty}");
    }

    private static void InputPlayerName(out string playerName){
        string _defaultName = playerName = "player";

        string prompt2 = $"What is your name? [default: player]";
        string msg1 = $"Your Player Name Set to, {playerName}";
        string msg2 = $"Default Player Name Set. {_defaultName}";
        
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

    }
}