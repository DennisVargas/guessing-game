using GuessingGameApp;
namespace GuessingGameTests;

[TestClass]
public class GuessingGameTests
{
    [TestMethod]
    public void TestUserInputNullName(){
        // tests if the output will be null when setting the output to 
        // null string.
        string? output = null;
        string? input = null;
        // when the input is null the function should return false
        // signifying the input failed and output was set to default.
        Assert.IsFalse(
            
            UserInputNewPlayerName(
                in input,out output));
        
        // test that when the input fails that the output is set
        // to "player".
        Assert.AreEqual<string>("player", output);

    }

    [TestMethod]
    public void TestUserInputEmptyName(){
        /* Tests setting player's name to empty string.
         The function should return false.
         The output default name is "player" in this case.*/
        string? input = string.Empty;
        string? output = string.Empty;
        
        /* UserInputNewPlayerName should return false when input is
         empty. */
        Assert.IsFalse(
            GGApp.UserInputNewPlayerName(
                in input, out output)    
        );
        // test that when the input fails that the output is set
        // to "player".
        Assert.AreEqual<string>("player", output);
    }

    [TestMethod]
    public void TestValidUserNameInput(){
        /*This test gives a text based name to the UserInput */
    }
}