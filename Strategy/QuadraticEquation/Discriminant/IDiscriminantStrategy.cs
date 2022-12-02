namespace Strategy.QuadraticEquation.Discriminant;

// The part b^2-4*a*c is called the discriminant in quadratic equation.
public interface IDiscriminantStrategy
{
    double CalculateDiscriminant(double a, double b, double c);
}
