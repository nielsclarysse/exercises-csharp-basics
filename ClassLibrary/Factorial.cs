using System.Numerics;

namespace ClassLibrary;

public class Factorial
{
    private readonly int _number;

    public Factorial(int number)
    {
        _number = number;
    }

    public BigInteger Calculate()
    {
        if (_number < 0) return 0;

        BigInteger result = 1;

        for (int i = _number; i > 1; i--)
        {
            result *= i;
        }

        return result;
    }
}