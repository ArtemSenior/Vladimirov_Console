using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int b = 60;
            int i = 1;
            Console.Write("n = ");
            do
            {
                try 
                { 
                n = Convert.ToInt32(Console.ReadLine());
                    if (n >=1 && n <= 25) 
                    { 
                        break;
                    }
                    Console.WriteLine("Введи числа от 1 до 25");
                }
                catch (Exception)
                {
                    Console.WriteLine("Введите целые числа!");
                }
            }
            while (true);
            Console.WriteLine("for");

            for (; i <= n; b = b - 2, i++)
            {
                    Console.WriteLine("Операция№" + i + "  " + b); 
                
            }

            Console.WriteLine("\nwhile");

            i = 1;
            b = 60;
            while (i <= n)
            {
                Console.WriteLine("Операция№ " + i + "  " + b);
                
                i++;
                b =b- 2;
            }

            Console.WriteLine("\ndo while");

            i = 1;
            b=60;
            do
            {
                Console.WriteLine("Операция№ " + i + "  " + b);
                i++;
                b = b- 2;
            }
            while (i <= n);
        }
    }
}