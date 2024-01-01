using GuessingGameLib;
using GuessingGameApp;


namespace GuessingGameTests;

[TestClass]
public class GuessingGameTests
{
    [TestMethod]
    [DataRow ("player", null, "player")]
    [DataRow("player", "","player")]
    public void TestInvalidStringInput(
        string _default, string _input, string _expected){
    // expected behavior: when given invalid input the function should
    // the out put value should be equal to _default and _expected.

        // when the input is null the function should return false
        // signifying the input failed and output was set to default.
        Assert.IsFalse(
            Util.ValidateStringInput(
                _default, in _input, out string output));
        // the output should be equal to _default and _expected.
        Assert.AreEqual<string>(_expected, output);
    }

    [TestMethod]
    [DataRow("player", "Dennis123@@", "Dennis123@@")]
    public void TestValidStringInput(
        string _default, string _input, string _expected){
        Assert.IsTrue(
            Util.ValidateStringInput(
                _default ,in _input, out string output));

        // When the input fails the output should be set to "player".
        Assert.AreEqual<string>(_expected, output);
    }

    [TestMethod]
    [DataRow(10, "20", 20)]
    [DataRow(10,"100", 100)]
    [DataRow(10,"2147483647", 2147483647)]
    public void TestValidMaxGuess(int _default, string input, int expectedOutput){
        // returns true when a string integer is passed into input.
        Assert.IsTrue(
            Util.ValidateIntInput(_default, in input, out int output));
        
        // output should be int representation of string.
        Assert.AreEqual<int>(expectedOutput, output);
    }

    [TestMethod]
    [DataRow(10, "abc", 10)]
    [DataRow(10, "!@#", 10)]
    [DataRow(10, "abc!@#", 10)]
    [DataRow(10, "", 10)]
    [DataRow(10, null, 10)]
    public void TestInvalidMaxGuess(int _default, string _input, int _expected){
        // returns true when a string integer is passed into input.
        Assert.IsFalse(
            Util.ValidateIntInput(_default, in _input, out int output));
        // when input is invalid the expected value is the default value.
        _expected = _default;
        // output should be int representation of string.
        Assert.AreEqual<int>(_expected, output);
    }
}