namespace Interpreter;

public static class Program
{
    static void Main()
    {
        var expressionProcessor = new ExpressionProcessor();
        expressionProcessor.AddNewVariable("x", 10);
        string expression = "300+x";
        int result = expressionProcessor.Calculate(expression);
        Console.WriteLine($"{expression} = {result}");
    }
}