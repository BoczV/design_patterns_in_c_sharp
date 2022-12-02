
using System.Text;

namespace Interpreter;

public class ExpressionProcessor
{
    private Dictionary<string, int> _variables = new();

    private List<char> expressions = new() {
        '+', '-'
    };

    private enum OperationTypes
    {
        Addition, Substraction
    }

    private OperationTypes? actualOperation = null!;

    public void AddNewVariable(string variable, int value)
    {
        _variables.Add(variable, value);
    }

    public int Calculate(string expression)
    {
        var result = int.Parse(expression[0].ToString());
        for (int j = 1; j < expression.Length; j++)
        {
            char element = expression[j];
            if (char.IsDigit(element))
            {
                (int actualValue, int increasedIndex) = ConcatenateNumberHigherThanNine(expression, expression.IndexOf(element));
                j = increasedIndex;
                if (actualOperation != null)
                {
                    switch (actualOperation)
                    {
                        case OperationTypes.Addition:
                            result += actualValue;
                            break;
                        case OperationTypes.Substraction:
                            result -= actualValue;
                            break;
                    }
                    actualOperation = null;
                }
            }
            else if (expressions.Contains(element))
            {
                switch (element)
                {
                    case '+':
                        actualOperation = OperationTypes.Addition;
                        break;
                    case '-':
                        actualOperation = OperationTypes.Substraction;
                        break;
                }
            }
            else
            {
                actualOperation = null;
                if (_variables.ContainsKey(element.ToString()))
                {
                    result += _variables[element.ToString()];
                }
                else
                {
                    return 0;
                }
            }
        }
        return result;
    }

    private static (int value, int charNumber) ConcatenateNumberHigherThanNine(string expression, int index)
    {
        var sb = new StringBuilder();
        var increasedIndex = 0;
        bool changedIncreasedIndex = false;
        for (int i = index; i < expression.Length; i++)
        {
            char element = expression[i];
            if (char.IsDigit(element))
            {
                sb.Append(element);
            }
            else
            {
                increasedIndex = i - 1;
                changedIncreasedIndex = true;
                break;
            }
        }
        string sbString = sb.ToString();
        return (int.Parse(sbString), changedIncreasedIndex ? increasedIndex : expression.Length - 1);
    }
}
