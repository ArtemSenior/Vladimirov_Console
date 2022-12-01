using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Порядковый номер = ");
                if (int.TryParse(Console.ReadLine(), out n))
                {
                    if (n >= 1 && n <= 12)
                    break;
                    else
                    {
                        Console.WriteLine("Введите число от 1 до 12");
                    }
                }
                else
                {
                    Console.WriteLine("Введите только целые числа!");
                }
            }
            while (true);

           
            switch (n) 
            {
                case 1:
                    Console.WriteLine("Осталось месяцев до конца года:" + (12 - n));
                    break;
                case 2:
                    Console.WriteLine("Осталось месяцев до конца года:" + (12 - n));
                    break;
                case 3:
                    Console.WriteLine("Осталось месяцев до конца года:" + (12 - n));
                    break;
                case 4:
                    Console.WriteLine("Осталось месяцев до конца года:" + (12 - n));
                    break;
                case 5:
                    Console.WriteLine("Осталось месяцев до конца года:" + (12 - n));
                    break;
                case 6:
                    Console.WriteLine("Осталось месяцев до конца года:" + (12 - n));
                    break;
                case 7:
                    Console.WriteLine("Осталось месяцев до конца года:" + (12 - n));
                    break;
                case 8:
                    Console.WriteLine("Осталось месяцев до конца года:" + (12 - n));
                    break;
                case 9:
                    Console.WriteLine("Осталось месяцев до конца года:" + (12 - n));
                    break;
                case 10:
                    Console.WriteLine("Осталось месяцев до конца года:" + (12 - n));
                    break;
                case 11:
                    Console.WriteLine("Осталось месяцев до конца года:" + (12 - n));
                    break;
                case 12:
                    Console.WriteLine("Осталось месяцев до конца года:" + (12 - n));
                    break;
            }
        }
    }
}