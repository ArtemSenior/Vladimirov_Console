using System;

namespace ConsoleApp1
{
    class Program
    {
        static double F(double n)
        {
            if (n == 1) return -10;
            if (n == 2) return 2;
            return Math.Abs(F(n - 2)) - 6 * F(n - 1);
        }
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("Введите n: ");
                    double x = Convert.ToDouble(Console.ReadLine());
                    if (x <= 0)
                    {
                        Console.WriteLine("Нельзя вводить числа меньше 0!");
                    }
                    else
                    {
                        Console.WriteLine(F(x));
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Вводить только числа");
                }
            }
            while (true);
        }
    }
}
