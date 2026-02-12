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

// *********
// * EX3-4 *
// *********

Lecturer profJones = new Lecturer("Indiana", "Jones", "EMP001");
Lecturer profSnape = new Lecturer("Severus", "Snape", "EMP002");

Student s1 = new Student("Alice", "Wonder", "S101", "AI");
Student s2 = new Student("Bob", "Builder", "S102", "Cloud");
Student s3 = new Student("Charlie", "Brown", "S103", "AI");

Group groupA = new Group("Advanced Robotics", profJones);
groupA.Students.Add(s1);
groupA.Students.Add(s2);

Group groupB = new Group("Potions & Ethics", profSnape);
groupB.Students.Add(s3);

Institute myUni = new Institute("Tech University");
myUni.Groups.Add(groupA);
myUni.Groups.Add(groupB);

//myUni.ShowInfo();