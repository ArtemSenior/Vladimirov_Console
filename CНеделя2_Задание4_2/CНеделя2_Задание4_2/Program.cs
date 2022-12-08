using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Rec(double a0, double d, int n, double s, out double an, out double sum)
        {
            an = a0;
            s += a0;
            sum = s;
            if (n == 1) return;
            Rec(a0 + d, d, n - 1, s, out an, out sum);
        }
        static void Main(string[] args)
        {
            do
            {
                double a0 = 0;
                double d = 0;
                int n = 0;
                do
                {
                    try
                    {
                        Console.Write("a0 = ");
                        a0 = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch 
                    {
                        Console.WriteLine("Вводите только числа");
                    }
                }
                while (true);

                do
                {
                    try
                    {
                        Console.Write("d = ");
                        d = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Вводите только числа");
                    }
                }
                while (true);

                do
                {                    
                    try
                    {
                        Console.Write("n = ");
                        n = int.Parse(Console.ReadLine());
                        if (n > 0) ;
                        break;
                    }

                    catch
                    {

                        Console.WriteLine("Где n > 1");
                    }

                }

                while (true);

                double an, sum;
                Rec(a0, d, n, 0, out an, out sum);
                Console.WriteLine($"An = {an}, sum = {sum}");
                break;

            } while (true);
        }
    }
}