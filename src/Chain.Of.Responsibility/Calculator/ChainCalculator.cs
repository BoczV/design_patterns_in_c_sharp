namespace Chain.Of.Responsibility.Calculator;

public class ChainCalculator
{
    private Handler root = null!;
    public ChainCalculator()
    {
        BuildChain();

    }

    private void BuildChain()
    {
        root = new AdditionHandler(new SubtractionHandler(new MultiplicationHandler(new DivisionHandler())));
    }

    public double HandleRequest(OperationType operationType, double number1, double number2)
    {
        return root.Handle(operationType, number1, number2);
    }
}
