namespace Chain.Of.Responsibility.Calculator;

public class SubtractionHandler : Handler
{
    public SubtractionHandler()
    {
    }

    public SubtractionHandler(Handler next) : base(next)
    {
    }

    public override double Handle(OperationType operationType, double number1, double number2)
    {
        if (operationType == OperationType.Subtraction)
        {
            Console.WriteLine("Let's do some subtraction!");
            return number1 - number2;
        }
        return base.Handle(operationType, number1, number2);
    }
}
