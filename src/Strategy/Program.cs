using Strategy.QuadraticEquation;
using Strategy.QuadraticEquation.Discriminant;

namespace Strategy;

public static class Program
{
    static void Main()
    {
        var discriminantStrategy = new OrdinaryDiscriminantStrategy();
        var quadraticEquationSolver = new QuadraticEquationSolver(discriminantStrategy);
        var result = quadraticEquationSolver.Solve(-2, -1, -3);
        Console.WriteLine($"First solution: {result.Item1.Real}, second solution: {result.Item2.Real}");
    }
}