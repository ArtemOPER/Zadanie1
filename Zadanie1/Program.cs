using System;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second, third;

            Console.WriteLine("Введите первое число");

            first = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            second = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число");

            third = double.Parse(Console.ReadLine());

            double result = first + second + third;

            double result1 = first * second * third;

            Console.WriteLine("результат: " + result);

            Console.WriteLine("результат: " + result1);
        }
    }
}
