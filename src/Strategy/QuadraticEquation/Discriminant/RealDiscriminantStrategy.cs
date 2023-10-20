namespace Strategy.QuadraticEquation.Discriminant;
public class RealDiscriminantStrategy : IDiscriminantStrategy
{
    public double CalculateDiscriminant(double a, double b, double c)
    {
        var result = b * b - 4 * a * c;
        return result < 0 ? double.NaN : result;
    }
}
