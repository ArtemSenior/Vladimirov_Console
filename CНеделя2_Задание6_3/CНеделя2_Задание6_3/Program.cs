using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CНеделя2_Задание6_3
{
    internal class Program
    {
        private static int onlyInt()
        {
            do
            {
                int res;
                bool parsed = int.TryParse(Console.ReadLine(), out res);
                if (parsed) return res;
                else Console.Write("Вводите только целые числа! Введенное число: ");

            } while (true);
        }

        static int[,] input2(int n, int m)
        {
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write("a[{0},{1}]= ", i, j);
                    a[i, j] = onlyInt();
                }
            return a;
        }
        static void print2(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write("{0,5} ", a[i, j]);
        }
        static int find(int[,] a, int n, int m)
        {
            int s = 0;
            int count = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (a[i, j] % 2 == 0)
                    {
                        s = s + a[i, j];
                        count++;
                    }

                }
            }
            s = s / count;
            return s;
        }

        static void Main(string[] args)
        {
            int n = 0, m = 0;
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Введите размерность массива");
                Console.Write("Количество n = ");
                n = onlyInt();
                m = n;
                if (n < 1 || m < 1)
                {
                    Console.WriteLine("Введите корректный размер массива!");
                }
                else flag = false;
            }

            int[,] myArray = input2(n, m);
            Console.WriteLine("Исходный массив:");
            print2(myArray);

            int arzn = find(myArray, n, m);
            Console.WriteLine("Среднее арифм = {0}", arzn);
        }
    }
}
