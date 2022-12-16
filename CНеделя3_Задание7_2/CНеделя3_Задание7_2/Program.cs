using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CНеделя3_Задание7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку, которая содержит осмысленное текстовое сообщение: ");
            string a = Convert.ToString(Console.ReadLine());

            int n = 0;

            do
            {
                try
                {
                    Console.Write("Введите n:");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ввод только целых положительных значений!");
                }
            }
            while (true);

            string[] nstring;
            nstring = a.Split(' ');
            for (int i = 0; i < nstring.Length; i++)
            {
                if (nstring[i].Length > n)
                {
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Слово, которое меньше чем n: " + nstring[i]);
                }
            }
        }
    }
}