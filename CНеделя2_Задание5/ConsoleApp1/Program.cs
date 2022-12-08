using System;
namespace Hello
{
    class Program
    {
        static double f(double x)
        {
            try
            {
                //если х не попадает в область определения, то генерируется исключение 
                if (x == 1) throw new Exception();
                else return 1 / (Math.Pow(x, 2) - 1);
            }
            catch
            {
                throw;
            }
        }

        static void Main(string[] args)
        {
            do
            {
                try
                {
                    Console.Write("a=");
                    double a = double.Parse(Console.ReadLine());
                    Console.Write("b=");
                    double b = double.Parse(Console.ReadLine());
                    if (a > b)
                    {
                        Console.WriteLine("а не может быть больше b");
                    }
                    else
                    {
                        do
                        {
                            Console.Write("h=");
                            double h = double.Parse(Console.ReadLine());
                            if (h < 0)
                            {
                                Console.WriteLine("Шаг не может быть отрицательным значением!");
                            }
                            else
                            {
                                for (double i = a; i <= b; i += h)
                                    try
                                    {
                                        Console.WriteLine("y({0})={1:f4}", i, f(i));                                        
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine(e.Message);
                                        break;
                                    }
                                break;
                            }
                            
                        } while (true);
                        break;    
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Неверный формат ввода данных");
                }
                catch
                {
                    Console.WriteLine("Неизвестная ошибка");
                }
            } while (true);           
        }
    }
}