using GuessingGameLib;


namespace GuessingGameApp;

class Menu
{
    internal enum Selection{
        None=-1, Play=1, Settings=2, Stats=3, Quit=4};
    public static void DisplayMainMenu(
        in Settings.Difficulty difficulty){
        string menu = 
            "***************************" + Util.NL +
            "* Guessing Game Main Menu *" + Util.NL +
            "***************************" + Util.NL +
            "* 1. Play Game            *" + Util.NL +
            "* 2. Game Settings        *" + Util.NL +
            "* 3. User Stats           *" + Util.NL +
            "* 4. Quit                 *" + Util.NL +
            "***************************";
        string difficultyMsg = $"Current Difficulty: {difficulty}";

        Console.Clear();
        Console.WriteLine(menu);
        Console.WriteLine(difficultyMsg);
    }
    private static void ProcessMenuSelection(
        in string? userInput, out Selection selection){
        // verify the input is valid, if not set _output to -1
        Util.ValidateIntInput(
            (int)Selection.None, in userInput, out int _output);
        // set to selection, invalid input is processed as None=-1;
        selection = (Selection)_output;
    }

    public static void InputMenuSelection(out Selection selection){
        // tell user to give input of menu selection number
        Console.WriteLine(Util.NL+"Please Make a Selection 1-4: ");
        // get userinput
        string? userInput = Console.ReadLine();
        ProcessMenuSelection(in userInput, out selection);
        Console.WriteLine($"You selected {selection}");
    }
}

