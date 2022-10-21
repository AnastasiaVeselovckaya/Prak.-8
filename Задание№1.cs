using System;

namespace Задание_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Х=");
            double x = double.Parse(Console.ReadLine());

            double y = 0;

            if (x >= 10)
            {
                y = 4 + Math.Pow(x,2) - Math.Pow(Math.E, Math. Sqrt (x));
            }
            else
            {
                y = 3.4 - x + 0.1 * Math.Pow(x,3);
            }

            Console.WriteLine("Результат Y={0}", y);

        }
    }
}
