using System;

namespace Задача__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите запланированный объем: ");
            var R = int.Parse(Console.ReadLine());
            Console.Write("Введите количество товара, выпущенного в первый день: ");
            var P = int.Parse(Console.ReadLine());
            Console.Write("Введите размер увеличения выпуска товара: ");
            var Q = int.Parse(Console.ReadLine());
            int n = 0;
            while (P < R)
            {
                P = P + Q;
                Q = Q + 1;
                n = n + 1;
            }
            Console.WriteLine("Потребуется дней: {0}", n + 1);
            Console.ReadKey();
        }
    }
}