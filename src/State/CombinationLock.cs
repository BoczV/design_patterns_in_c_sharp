using System.Text;

namespace State;

public class CombinationLock
{
    private string? _code;
    private string? _status;

    public string Status { get => _status ?? "LOCKED"; }

    public CombinationLock(int[] combination) => SetNewCombination(combination);

    public void EnterDigit(int digit)
    {
        if (_status == "LOCKED")
        {
            _status = "";
        }
        _status += digit;
        if (_status == _code)
        {
            _status = "OPEN";
        }
        if (_status.Length == _code.Length)
        {
            _status = "ERROR";
        }
    }

    public void SetNewCombination(int[] combination)
    {
        var stringBuilder = new StringBuilder();
        for (int i = 0; i < combination.Length; i++)
        {
            stringBuilder.Append(combination[i]);
        }
        _code = stringBuilder.ToString();
        _status = "LOCKED";
    }
}
