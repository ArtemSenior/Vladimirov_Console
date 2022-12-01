using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, s;
            do
            {
                try
                {
                    Console.Write("p = ");
                    p = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Вводить только числа!!!");
                }
            }
            while (true);
            s = Math.Pow(p, 2) * Math.Sqrt(3) / 36;
            Console.WriteLine("Площадь равностороннего треугольника равна " + s);
        }
    }
}
