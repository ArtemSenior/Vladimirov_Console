using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CНеделя2_Задание6_2
{
    internal class Program
    {
        private static double readInt()
        {
            do
            {   //Проверка на ввод данных
                double result;
                bool parsed = double.TryParse(Console.ReadLine(), out result);
                if (parsed) return Convert.ToInt32(result);
                else Console.Write("Вводите только целые числа! Введенное число: ");

            } while (true);
        }


        static double[] input()
        {
            Console.Write("Размерность массива: ");
            double n = readInt();
            double[] a = new double[Convert.ToInt32(n)];
            for (double i = 0; i < n; ++i)
            {
                Console.Write("a[{0}]= ", i);
                a[Convert.ToInt32(i)] = readInt();
            }
            return a;
        }

        static void print(double[] a)
        {
            for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
            Console.WriteLine();
        }

        static void printIlement(double[] a, double min)
        {
            for (double i = 0; i < a.Length; ++i)
            {
                if (a[Convert.ToInt32(i)] == min)
                {
                    Console.WriteLine($"Элемент под номером {i} является минимальным");;
                }
            }
        }

        static double min(double[] a)
        {
            double min = a[0];
            for (int i = 1; i < a.Length; ++i)
                if (a[i] < min) min = a[i];
            return min;
        }

        static void Main(string[] args)
        {
            double[] myArray = input();
            Console.WriteLine("Исходный массив:");
            print(myArray);
            printIlement(myArray, min(myArray));

        }
    }
}
