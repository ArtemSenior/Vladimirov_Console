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
            float x, y;
            do
            {
                Console.Write("X=");
                if (!float.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Введите целые числа");
                    continue;
                }
                else
                    break;
            } while (true);
            
            do
            {
                Console.Write("Y=");
                if (!float.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Введите цифры");
                    continue;
                }
                else
                    break;
            } while (true);

            if (x > 0 && x * x + y * y < 81)
                Console.WriteLine("Внутри");
            else if ((x > 0 && x * x + y * y == 81) || (x == 0 && y <= 9 && -9 <= y))
                Console.WriteLine("На границе");
            else Console.WriteLine("Вне границы");
        }
    }
}
