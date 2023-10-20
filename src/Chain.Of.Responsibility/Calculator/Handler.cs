namespace Chain.Of.Responsibility.Calculator;

public abstract class Handler
{

    private Handler _next = null!;
    public virtual double Handle(OperationType operationType, double number1, double number2) => _next.Handle(operationType, number1, number2);

    protected Handler(Handler next)
    {
        _next = next;
    }

    protected Handler()
    {

    }

    public void Add(Handler next)
    {
        _next = next;
    }
}
