using System;
using Tyuiu.PautovaMO.Sprint4.Task7.V26.Lib;

namespace Tyuiu.PautovaMO.Sprint4.Task7.V26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int m = 3;
            int[,] matrx = new int[n, m];
            string value = "351268459614723";
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Паутова М.О. | ИБКСб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #26                                                             *");
            Console.WriteLine("* Выполнил: Паутова Мария Олеговна | ИБКСб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка '351268459614723'. Преобразовать в матрицу 5x3 и            *");
            Console.WriteLine("* подсчитать произведение четных чисел.                                   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");



            // Вывод матрицы
            Console.WriteLine("\nПолученная матрица:");
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{value[index]} \t ");
                    index++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(n, m, value);
            Console.WriteLine($"Произведение четных чисел = {res}");

            Console.ReadKey();
        }
    }
}