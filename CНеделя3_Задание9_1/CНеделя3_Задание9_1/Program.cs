using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CНеделя3_Задание9_1
{
    internal class Program
    {
        private static double readDouble()
        {
            do
            {   //  ввод
                double result;
                bool parsed = double.TryParse(Console.ReadLine(), out result);
                if (parsed) return result;
                else Console.Write("Ошибка. Введите степень 3: ");

            } while (true);

        }
        static void Main(string[] args)
        {
            bool a = true;
            double s = 0;
            while (a)
            {
                Console.Write("Введите степень числа 3: ");
                s = 0;
                s = readDouble();
                if (s < 0)
                {
                    Console.WriteLine("Введите корректную степень 3!");
                }
                else a = false;
            }

            if (s != 0)
            {
                using (StreamWriter sw = new StreamWriter(@"E:\ПРАКТИКА\Неделя 3\CНеделя3_Задание9_1\zad9.txt"))
                {
                    for (double i = 0; i <= s; i++)
                    {
                        sw.WriteLine(Math.Pow(3, i));
                    }
                }
                using (StreamReader sr = new StreamReader(@"E:\ПРАКТИКА\Неделя 3\CНеделя3_Задание9_1\zad9.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string str;

                        str = sr.ReadLine();
                        sr.ReadLine();
                        Console.WriteLine(str);

                    }
                }
            }
        }
    }
}
