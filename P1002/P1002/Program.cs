using System;
using System.Globalization;
namespace P1002
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14159;
            double raio = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.WriteLine($"A={(pi*Math.Pow(raio, 2)).ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}