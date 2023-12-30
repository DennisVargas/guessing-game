namespace GuessingGameLib;

public class Util
{
    public static readonly string NL = $"{Environment.NewLine}";

    public static bool ValidateStringInput(
        in string _default, in string? _input, out string _output)
    {
        if (!string.IsNullOrEmpty(_input))
        {
            _output = _input;
            return true;
        }
        else
        {
            _output = _default;
            return false;
        }
    }
    public static bool ValidateIntInput(
        in int _default, in string? _input, out int _output)
    {
        if (!string.IsNullOrEmpty(_input))
        {
            if (int.TryParse(_input, out int result))
            {
                _output = result;
                return true;
            }
        }
        _output = _default;
        return false;
    }
}
