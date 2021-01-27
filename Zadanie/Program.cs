using System;

namespace Zadanie
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second;

            Console.WriteLine("Введите первое число");

            first = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Введите второе число");

            second = double.Parse(Console.ReadLine());

            double result = (first + second) / 2;

            Console.WriteLine("результат: " + result);
        }
    }
}
