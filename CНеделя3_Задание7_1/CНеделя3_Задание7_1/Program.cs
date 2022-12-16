using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CНеделя3_Задание7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввод: ");
            StringBuilder sb = new StringBuilder(Console.ReadLine());

            for (int i = 0; i < sb.Length - 1; i += 2)
            {
                if (sb[i] == ' ' || sb[i + 1] == ' ') // если пробел || если след. пробел то откат на 2 символа назад
                {
                    i -= 1;
                }
                else
                {
                    char buf = sb[i];
                    sb[i] = sb[i + 1];
                    sb[i + 1] = buf;
                }
            }
            Console.WriteLine(sb);
        }
    }
}