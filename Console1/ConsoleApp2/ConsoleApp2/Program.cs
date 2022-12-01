using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 0;
            do
            {
                try
                {
                    Console.Write("Проверка на четность числа. Введите число: ");
                    a = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Вводить только целые числа!!!");
                }
            }
            while (true);
            if (a % 2 == 0)
                    {
                        Console.WriteLine("Число "+a+" является четным.");
                    }
                        else
                        {
                            Console.WriteLine("Число " + a + " четным НЕ ЯВЛЯЕТСЯ!");
                        }
        }
    }
}
