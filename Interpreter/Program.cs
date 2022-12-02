namespace Interpreter;

public static class Program
{
    static void Main()
    {
        var expressionProcessor = new ExpressionProcessor();
        expressionProcessor.AddNewVariable("x", 100);
        expressionProcessor.GetOneExpression("2*x");
        var result = expressionProcessor.Calculate();
        Console.WriteLine($"Result is: {result}");
    }
}