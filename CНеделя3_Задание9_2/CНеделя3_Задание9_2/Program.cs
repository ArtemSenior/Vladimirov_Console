using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CНеделя3_Задание9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamreader = new StreamReader(@"E:\ПРАКТИКА\Неделя 3\CНеделя3_Задание9_2\zad9_2.txt");

            string line = streamreader.ReadLine();

            int count = 0;

            char[] chars = line.ToCharArray();

            while (line != null)
            {
                chars = line.ToCharArray();
                char buf = char.ToUpper(chars[0]);
                char buf2 = char.ToUpper(chars[chars.Length - 1]);
                if (buf == buf2) count++;
                line = streamreader.ReadLine();
            };

            streamreader.Close();

            Console.WriteLine("Кол-во строк, начинающиеся и заканчивающиеся на одну и ту же букву: " + count + "\n");

        }
    }
}
