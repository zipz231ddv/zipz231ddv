using System;

namespace SumCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("number 1");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("number 2");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double sum = number1 + number2;

            Console.WriteLine($"{number1}+{number2}={sum}");
            Console.ReadKey();
        }
    }
}
