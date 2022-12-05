namespace Chain.Of.Responsibility.Calculator;

public class MultiplicationHandler : Handler
{
    public MultiplicationHandler() { }

    public MultiplicationHandler(Handler next) : base(next) { }

    public override double Handle(OperationType operationType, double number1, double number2)
    {
        if (operationType == OperationType.Multiplication)
        {
            Console.WriteLine("Let's do some multiplication!");
            return number1 * number2;
        }
        return base.Handle(operationType, number1, number2);
    }
}
