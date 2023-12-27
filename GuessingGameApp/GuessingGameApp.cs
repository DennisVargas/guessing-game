using System.Security.Cryptography;

namespace GuessingGameApp;
public class GGApp
{
    private readonly struct GameConfig{

        private GameConfig(string playerName, int maxGuesses, int rangeLimit){
            this.PlayerName = playerName;
            this.MaxGuesses = maxGuesses;
            this.RangeLimit = rangeLimit;
        }
        public string PlayerName {get; init;}
        public int MaxGuesses{get; init;}
        public int RangeLimit{get; init;}
    }
    public static bool UserInputNewPlayerName(in string? userInput ,out string playerName){
        // If the name is empty then the player will named as such.
        if(!string.IsNullOrEmpty(userInput)){
            playerName = userInput;
            return true;
        }else{
            playerName = "player";
            return false;
        }
    }

    internal static int InputMaxGuesses()
    {
        int maxGuesses = int.MinValue;
        Console.WriteLine("How many guesses would you like to make"+
        " before the game is over? [default: 10]");
        string? input = Console.ReadLine();
        if(string.IsNullOrEmpty(input)){
            if(int.TryParse(input, out maxGuesses)){
                Console.WriteLine("Max guesses set to: {input}");

            }
        }
        return maxGuesses;
    }
    private static int InputRangeLimit()
    {
        throw new NotImplementedException();
    }

    private static void SetupGame(){
        // setups up the configuration for the game.
        Console.WriteLine("How would you like to be called?\n"+
        "What is your name? [default: player]");

    }

    private static void Main(string[] args)
    {

        // GameConfig config = new GameConfig(InputPlayerName(),InputMaxGuesses(), InputRangeLimit());
        Console.WriteLine("Guess which number I am thinking of"+
        " between 1 and 10? (Or type 'Quit' to leave.)");
        int guessNum = -1;
        int randNum = -1;
        string? input = null;
        bool quit = false;
        // Greet Player
        do{
            input = Console.ReadLine();
            // check that input isn't null
            if (!string.IsNullOrEmpty(input))
            {
                if (int.TryParse(input, out guessNum)){
                    Console.WriteLine($"You've guessed, {guessNum}.");
                    randNum = RandomNumberGenerator.GetInt32(11);
                    if(guessNum != randNum)
                        Console.WriteLine($"You Lose. {guessNum}, is "+
                        $"incorrect. My number is {randNum}.");
                    else 
                        Console.WriteLine($"You Win. {guessNum}, is "+
                        $"correct. My number is {randNum}");
                    Console.WriteLine("Go Again? Y/N");
                    input = Console.ReadLine();
                }
                else if (input.ToLower().Equals("quit")) {
                    Console.WriteLine("Quit: Press any of the keys.");
                    Console.ReadKey();
                    quit = true;
                    break; 
                }else {

                }
            }
            else
                Console.WriteLine("Blank input is not valid. If you"+
                "would like to leave please type 'Quit'."+
                "Otherwise Please input a number between 1 and 10.");
        }while(!quit);
    }

}

// old library file below that i may just delete.....
// [todo]: check it out and blow it away if its not neccesary later

// using System.Text.RegularExpressions;

// namespace GuessingGame.Config;

// public partial class GuessingGameConfig{
//     private string playerName;
//     private int maxGuesses;
//     private int rangeLimit;
    
//     [GeneratedRegex(@"^[a-zA-Z]+$")]
//     private static partial Regex OnlyLetters();

    
//     public GuessingGameConfig(string name, string? maxGuesses, string? rangeLimit)
//     {
//             this.playerName = name;
//         // set the player name

//         // set the max guesses
//             // parse the string for an int
//             // if the parse works pass the int to max guesses
//             // else throw an error about wrong input
//             // ask to try again or to type 'q' to quit
//         // set the range limit

//     }
//     public GuessingGameConfig(){
//         playerName = "player";
//         maxGuesses = 3;
//         rangeLimit = ;
//     }
//     public bool GetUserStringInput(string msg,out string stringInput){
//         Console.WriteLine(msg);
//         var input = Console.ReadLine();
//         if (string.IsNullOrEmpty(input)){
//             stringInput = string.Empty;
//             return false;
//         }else{
//             stringInput = input;
//             return true;
//         }
//     }
 
//     public bool SetPlayerName(string playerName){
//             this.playerName = playerName;
//             return true;
//     }




//     // private readonly struct GameConfig{
//     //     public GameConfig(){

//     //     }
//     //     public GameConfig(string playerName, int maxGuesses, int rangeLimit){
//     //         this.PlayerName = playerName;
//     //         this.MaxGuesses = maxGuesses;
//     //         this.RangeLimit = rangeLimit;
//     //     }
//     //     public string PlayerName {get; init;}
//     //     public int MaxGuesses{get; init;}
//     //     public int RangeLimit{get; init;}
//     // }

//     // private static int SetInputRangeLimit()
//     // {
//     //     bool validInput = false;
//     //     int rangeLimit = int.MinValue;
//     //     do{
//     //         if (!validInput)
//     //             Console.WriteLine($"Please enter a number!");
//     //         Console.WriteLine("What is the maximum number value I select from?");
//     //         string? input = Console.ReadLine();
//     //         if (int.TryParse(input, out rangeLimit)){
//     //             // user entered a number
//     //             // check if the number is a positive number
//     //         }else{
//     //             Console.WriteLine("You did not enter a number!");
//     //             validInput = false;
//     //         }
//     //     }while(!validInput);
//     //     return rangeLimit;
//     // }
//     // public bool Wacky(){
//     //         throw new NotImplementedException("Please create a test first.");
//     // }

// }
