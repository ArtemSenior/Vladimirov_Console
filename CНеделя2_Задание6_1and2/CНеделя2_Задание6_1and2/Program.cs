namespace CНеделя2_Задание6_1and2
{
    internal class Program
    {
        // одномерный массив и двумерный
        private static int onlyInt()
        {
            // Проверяется ввод int
            do
            {
                int res;

                bool pr = int.TryParse(Console.ReadLine(), out res);

                if (pr) return res; //если true выводится res

                else Console.Write("Возможен ввод только целого числа! Введите число: ");

            } while (true);
        }


        static int[] arr() // выбор размерности массива, его заполнение
        {
            Console.Write("Размерность массива: ");
            int n = onlyInt();
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write($"a[{i}] = ");
                a[i] = onlyInt();
            }
            return a;
        }

        static void print(int[] a)
        {
            for (int i = 0; i < a.Length; ++i) Console.Write($"{a[i]} ");
            Console.WriteLine();
        }

        static void сhange(int[] a, int b)
        {
            for (int i = 0; i < a.Length; ++i)
                if (a[i] < b) a[i] = b;
        }

        //Двумерный массив
        static int[,] arr2(out int n, out int m)
        {
            Console.WriteLine("Размерность массива");
            Console.Write("Количество n = ");
            n = onlyInt();
            Console.Write("Количество m = ");
            m = onlyInt();
            int[,] a = new int[n, m];
            for (int i = 0; i < n; ++i)
                for (int j = 0; j < m; ++j)
                {
                    Console.Write($"a[{i},{j}]= ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            return a;
        }

        static void print2(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); ++i, Console.WriteLine())
                for (int j = 0; j < a.GetLength(1); ++j)
                    Console.Write($"{a[i, j]} ");
        }

        static void change2(int[,] a, int b)
        {
            for (int i = 0; i < a.GetLength(0); ++i)
                for (int j = 0; j < a.GetLength(1); ++j)
                    if (a[i, j] < b) a[i, j] = b;
        }


        static void Main(string[] args)
        {
            // Одномерный arr
            int[] array = arr();
            Console.WriteLine("Одномерный массив:");
            print(array);
            Console.Write("Задайте число которым заменить все элементы, меньшие заданного числа, этим числом: ");
            int a = onlyInt();
            сhange(array, a);
            Console.WriteLine("Измененный массив:");
            print(array);

            // Двумерный arr
            int n, m;
            int[,] array2 = arr2(out n, out m);
            Console.WriteLine("Двумерный массив:");
            Console.Write("Задайте число которым заменить все элементы, меньшие заданного числа, этим числом: ");
            int b = onlyInt();
            change2(array2, a);
            Console.WriteLine("Измененный массив:");
            print2(array2);


        }

    }
}
