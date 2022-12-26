using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CНеделя3_Задание10
{
        class Program
        {
            static void Main(string[] args)
            {
                Directory.CreateDirectory("c:\\temp");
                Directory.CreateDirectory("c:\\temp\\K1");
                Directory.CreateDirectory("c:\\temp\\K2");
                StreamWriter sw = new StreamWriter("c:\\temp\\K1\\t1.txt");
                sw.Write("Владимиров Артем Игоревич, 08.11.2001, Россия г.Владимир");
                sw.Close();
                sw = new StreamWriter("c:\\temp\\K1\\t2.txt");
                sw.Write("Владимиров Артем Игоревич, 08.11.2002, Россия г.Владимир");
                sw.Close();

                sw = new StreamWriter("c:\\temp\\K2\\t3.txt");
                StreamReader sr = new StreamReader("c:\\temp\\K1\\t1.txt");
                var read = sr.ReadToEnd();
                sw.WriteLine(read);
                sr.Close();

                sr = new StreamReader("c:\\temp\\K1\\t2.txt");
                read = sr.ReadToEnd();
                sw.WriteLine(read);
                sr.Close();
                sw.Close();

                DirectoryInfo d = new DirectoryInfo("c:\\temp\\K1\\");
                DirectoryInfo d3 = new DirectoryInfo("c:\\temp\\K2\\");
                FileInfo[] f = d.GetFiles();
                FileInfo[] f3 = d3.GetFiles();
                Console.WriteLine("K1:");
                foreach (FileInfo i in f)
                {
                    Console.WriteLine("Имя: " + i.Name.ToString() + "\n"
                        + "Путь: " + i.FullName.ToString() + "\n"
                        + "Размер: " + i.Length.ToString() + "кб\n"
                        + "Время создания: " + i.CreationTime.ToString() + "\n");
                }
                Console.WriteLine("K2:");
                foreach (FileInfo i in f3)
                {
                    Console.WriteLine("Имя: " + i.Name.ToString() + "\n"
                        + "Путь: " + i.FullName.ToString() + "\n"
                        + "Размер: " + i.Length.ToString() + "кб\n"                    
                        + "Время создания: " + i.CreationTime.ToString() + "\n");
                }


                File.Move("c:\\temp\\K1\\t2.txt", "c:\\temp\\K2\\t2.txt");
                File.Copy("c:\\temp\\K1\\t1.txt", "c:\\temp\\K2\\t1.txt");
                Directory.Move("c:\\temp\\K2", "c:\\temp\\ALL");
                Directory.Delete("c:\\temp\\K1", true);

                DirectoryInfo h = new DirectoryInfo("c:\\temp\\ALL\\");
                FileInfo[] j = h.GetFiles();
                Console.WriteLine("All:");
                foreach (FileInfo i in j)
                {
                    Console.WriteLine("Имя: " + i.Name.ToString() + "\n"
                        + "Путь: " + i.FullName.ToString() + "\n"
                        + "Размер: " + i.Length.ToString() + "кб\n"
                        + "Время создания: " + i.CreationTime.ToString() + "\n");
            }
            }
        }
}