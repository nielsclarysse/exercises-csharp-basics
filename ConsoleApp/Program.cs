using ClassLibrary;

// *****************
// * EX0 - Warm Up *
// *****************

IEnumerable<int> Fibonacci(int length)
{
    (int a, int b) = (1, 1);

    for (int i = 0; i < length; i++)
    {
        yield return a;

        (a, b) = (b, a + b);
    }
}

foreach (int i in Fibonacci(10))
{
    //Console.WriteLine(i);
}

// ***********
// * EX1 - A *
// ***********

Factorial fac = new Factorial(5);
//Console.WriteLine(fac.Calculate());