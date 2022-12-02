using Strategy.QuadraticEquation.Discriminant;
using System.Numerics;

namespace Strategy.QuadraticEquation;

public class QuadraticEquationSolver
{
    private readonly IDiscriminantStrategy _discriminantStrategy;

    public QuadraticEquationSolver(IDiscriminantStrategy discriminantStrategy)
    {
        _discriminantStrategy = discriminantStrategy;
    }

    public Tuple<Complex, Complex> Solve(double a, double b, double c)
    {
        var discriminant = _discriminantStrategy.CalculateDiscriminant(a, b, c);

        if (double.IsNaN(discriminant))
        {
            return new Tuple<Complex, Complex>(double.NaN, double.NaN);
        }

        double nthRoot = NthRoot(discriminant, 2);

        double aMultipliedByTwo = 2 * a;

        var plus = (-b + nthRoot) / aMultipliedByTwo;
        var minus = (-b - nthRoot) / aMultipliedByTwo;

        return new Tuple<Complex, Complex>(plus, minus);
    }

    private static double NthRoot(double number, int nthRoot)
    {
        return Math.Pow(number, 1.0 / nthRoot);
    }
}
