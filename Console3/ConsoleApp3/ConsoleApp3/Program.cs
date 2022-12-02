using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    internal class Program
    {
        static void f(double x, out double y)
        { 
            y = 0;
            if (Math.Abs(x) < (Math.PI / 2)) y = Math.Sin(x);
            else if (Math.Abs(x) <= Math.PI) y = Math.Cos(x);
            else y = 0;

        }
        static double f(double x)
        {
            double y = 0;
            if (Math.Abs(x) < (Math.PI / 2)) y = Math.Sin(x);
            else if (Math.Abs(x) <= Math.PI) y = Math.Cos(x);
            else y = 0;
            return y;
        }
        static void Main(string[] args)
        {
            double a;
            double b;
            double h;
            Console.Write("a=");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.Write("Ошибка! Введите число a=");
                    continue;
                }
                else break;
            }
            Console.Write("b=");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.Write("Ошибка! Введите число b=");
                    continue;
                }
                else break;
            }
            while (true)
            {
                if (a > b)
                {
                    Console.Write("a не может быть больше b");
                    Console.Write("\na=");
                    a = double.Parse(Console.ReadLine());
                    Console.Write("b=");
                    b = double.Parse(Console.ReadLine());
                    continue;
                }
                else break;
            }
            Console.Write("h=");
            while (true)
            {
                if (!double.TryParse(Console.ReadLine(), out h))
                {
                    Console.Write("Ошибка! Введите число h=");
                    continue;
                }
                else if (h <= 0)
                {
                    Console.Write("Шаг не может быть отрицательным или равным 0! h=");
                    continue;
                }
                else break;
            }
            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
            for (double i = a; i <= b; i += h)
            {
                f(i, out double y);
                Console.WriteLine("f({0:f2})={1:f4}", i, f(i));
            }
        }
    }
}