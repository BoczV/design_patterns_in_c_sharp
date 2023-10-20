namespace Chain.Of.Responsibility.Calculator;

public class DivisionHandler : Handler
{
    public DivisionHandler() { }

    public DivisionHandler(Handler next) : base(next)
    {
    }

    public override double Handle(OperationType operationType, double number1, double number2)
    {
        if (operationType == OperationType.Division)
        {
            Console.WriteLine("Let's do some division!");
            return number1 / number2;
        }
        return base.Handle(operationType, number1, number2);
    }
}
