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

Factorial faca = new Factorial(5);
//Console.WriteLine(faca.Calculate());

// ***********
// * EX1 - B *
// ***********

Factorial facb = new Factorial() { Number = 5 };
//Console.WriteLine(facb.Calculate());

// ***********
// * EX1 - C *
// ***********

if (args.Length > 0 && int.TryParse(args[0], out int number))
{
    //Console.WriteLine(Factorial.Calculate(number));
}

// ***********
// * EX1 - D *
// ***********

Factorial facd = new Factorial(5);
//Console.WriteLine(facd.Calculate());

// *******
// * EX2 *
// *******

Temperature temperature = new Temperature() { Celsius = 21 };
//Console.WriteLine(temperature.Celsius);
//Console.WriteLine(temperature.Fahrenheit);
//Console.WriteLine(temperature.Kelvin);

//temperature.Celsius = 23;
//temperature.Fahrenheit = 75;

(double c, double f, _) = temperature;
//Console.WriteLine($"{c} °C is {f}°F");