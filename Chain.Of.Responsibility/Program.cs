using Chain.Of.Responsibility.Calculator;

namespace Chain.Of.Responsibility;


public static class Program
{
    static void Main()
    {
        var chainCalculator = new ChainCalculator();
        double result = chainCalculator.HandleRequest(OperationType.Multiplication, 5, 2);
        Console.WriteLine($"Result is: {result}");
    }
}