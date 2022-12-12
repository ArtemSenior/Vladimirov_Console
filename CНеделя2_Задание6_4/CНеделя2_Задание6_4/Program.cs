using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CНеделя2_Задание6_4
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.Write("Размерность массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[][] myArray_1 = new int[n][];
                int[] minArray = new int[n];
                Random rnd = new Random();

                for (int i = 0; i < n; i++)
                {
                    myArray_1[i] = new int[n];
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{i},{j} = ");
                        myArray_1[i][j] = int.Parse(Console.ReadLine());
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write($"{myArray_1[i][j]}\t");
                    }
                    Console.WriteLine();
                }

                int[] rez = new int[n];
                int min;
                for (int j = 0; j < n; j++)
                {
                    min = 0;
                    for (int i = 0; i < n; i++)
                    {
                        if (myArray_1[min][j] > myArray_1[i][j])
                        {
                            min = i;
                        }
                    }
                    rez[j] = myArray_1[min][j];
                }

                Console.WriteLine("\n~~ Минимальные Элементы ~~");
                foreach (int value in rez)
                    Console.Write("{0} ", value);
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка, введите число!");
            }
        }
    }
}

