namespace ClassLibrary;

public class Temperature()
{
    public double Celsius { get; init; } = 25.0;
    public double Fahrenheit => (Celsius * 1.8) + 32;
    public double Kelvin => Celsius + 273.15;

    public void Deconstruct(out double celsius, out double fahrenheit, out double kelvin)
    {
        celsius = Celsius;
        fahrenheit = Fahrenheit;
        kelvin = Kelvin;
    }
}