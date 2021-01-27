using System;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double chislo;

            Console.WriteLine("Введите число на которое хотите умножить $ ");

            chislo = double.Parse(Console.ReadLine());

            double result = chislo * 75.06;

            Console.WriteLine(result);




        }
    }
}
