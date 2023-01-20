namespace Interpreter;

public class ExpressionProcessor
{
    private readonly Dictionary<string, double> _variables = new();

    private readonly List<char> expressionTypes = new() {
        '+', '-', '*', '/',
    };

    private readonly List<Expression> expressions = new();

    public void AddNewVariable(string variable, int value)
    {
        _variables.Add(variable, value);
    }

    public void GetOneExpression(string expressionString)
    {
        string newExpressionString = expressionString.Replace(",", ".");
        for (int i = 0; i < newExpressionString.Length; i++)
        {
            char expressionChar = newExpressionString[i];
            if (expressionTypes.Contains(expressionChar))
            {
                string firstNumberStr = newExpressionString[..i];

                double helperFirstNumber = GetNumericValue(firstNumberStr);

                string secondNumberStr = newExpressionString.Substring(i + 1);

                double helperSecondNumber = GetNumericValue(secondNumberStr);

                OperationType operationType =
                    expressionChar == '+' ? OperationType.Addition :
                    expressionChar == '-' ? OperationType.Subtraction :
                    expressionChar == '*' ? OperationType.Multiplication : OperationType.Division;

                expressions.Add(new Expression(helperFirstNumber, helperSecondNumber, operationType));
            }
        }
    }

    private double GetNumericValue(string stringValue)
    {
        double getNumber;
        if (Double.TryParse(stringValue, out getNumber))
        {
            return getNumber;
        }
        else
        {
            if (_variables.ContainsKey(stringValue))
            {
                return _variables[stringValue];
            }
            throw new InvalidOperationException();
        }
    }

    public double Calculate()
    {
        double result = 0;

        expressions.ForEach(expression => result += expression.Process());

        return result;
    }
}
