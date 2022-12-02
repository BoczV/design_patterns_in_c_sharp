namespace Chain.Of.Responsibility.Calculator;

public class AdditionHandler : Handler
{
    public AdditionHandler()
    {
    }

    public AdditionHandler(Handler next) : base(next)
    {
    }



    public override double Handle(OperationType operationType, double number1, double number2)
    {
        if (operationType == OperationType.Addition)
        {
            Console.WriteLine("Let's do some addition!");
            return number1 + number2;
        }
        return base.Handle(operationType, number1, number2);
    }
}
