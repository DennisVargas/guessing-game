// using System.Runtime.CompilerServices;


// [assembly: InternalsVisibleTo("GuessingGameTests")]


namespace GuessingGameApp;

public class GuessingGame
{
    public static void RunGame()
    {
        Settings settings = new();
        Menu.DisplayMainMenu(settings.difficulty);
    }
}
