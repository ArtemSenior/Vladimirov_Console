using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CНеделя3_Задание8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите осмысленное сообщение: ");
            string a = Console.ReadLine();
            Console.Write("Введите слово: ");
            string words = Console.ReadLine();
            Regex regex = new Regex(@"\b" + words + @"\b", RegexOptions.IgnoreCase);

            if (regex.IsMatch(a))
            {
                Console.WriteLine("\nСообщение содержит заданное слово");
            }
            else
            {
                Console.WriteLine("\nСообщение не содержит заданное слово");
            }
        }
    }
}
