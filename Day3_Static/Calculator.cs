using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Static;

internal class Calculator
{
    public void Toplama(int a, int b)
    {
        Console.WriteLine($"{a} + {b} = {a+b}");
    }

    public void Cikarma(int a, int b)
    {
        Console.WriteLine($"{a} - {b} = {a - b}");
    }

    public void Carpma(int a, int b)
    {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }

    public void Bolme(double a, double b)
    {
        Console.WriteLine($"{a} / {b} = {a / b}");
    }
}
