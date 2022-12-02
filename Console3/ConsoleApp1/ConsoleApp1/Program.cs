using System;

namespace Hello
{
    class Program
    {
        static double min(double a, double b)
        {
            return (a < b) ? a : b;
        }

        static void Main(string[] args)
        {
            double x, y, z, v;
            do
            {
                try
                {
                    Console.Write("x=");
                    x = double.Parse(Console.ReadLine());

                    Console.Write("y=");
                    y = double.Parse(Console.ReadLine());

                    Console.Write("z=");
                    z = double.Parse(Console.ReadLine());

                    Console.Write("v=");
                    v = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Вводите числа");
                }
            }
            while (true);

            double q = min(x, y);
            double w = min(z, v);
            double res = min(q, w);

            Console.WriteLine(res);
        }
    }
}