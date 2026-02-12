namespace ClassLibrary;

public class Factorial()
{
    public int Number { get; set; }

    public Factorial(int number) : this()
    {
        Number = number;
    }

    public long Calculate()
    {
        return Calculate(Number);
    }

    public static long Calculate(int number)
    {
        if (number < 0) return 0;
        if (number == 0) return 1;

        long result = 1;

        for (int i = number; i > 1; i--)
        {
            result *= i;
        }

        return result;
    }
}