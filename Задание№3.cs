using System;

namespace Задание_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите x = ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите y = ");

            double y = double.Parse(Console.ReadLine());

            if (x == 0 && y <= 9 && y >= -9)
            {
                Console.WriteLine("На границе");
                return;
            }

            double a = Math.Pow(x, 2) + Math.Pow(y, 2);
            if (a == 81)
            {
                Console.WriteLine("На границе");
                return;
            }

            if (a <= 81)
                Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");
            Console.ReadKey();
        }
    }