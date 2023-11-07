namespace Day3_Static;

internal class CalculatorStatik
{
    public static void Toplama(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a + b}");
    }

    public static void Cikarma(int a, int b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }

    public static void Carpma(int a, int b)
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }

    public static void Bolme(double a, double b)
    {
        Console.WriteLine($"{a} / {b} = {a / b}");
    }
}
