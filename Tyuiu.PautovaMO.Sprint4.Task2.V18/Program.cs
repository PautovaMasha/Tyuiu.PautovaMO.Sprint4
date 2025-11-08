using System.Net;
using Tyuiu.PautovaMO.Sprint4.Task2.V18.Lib;

namespace Tyuiu.PautovaMO.Sprint4.Task2.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил : Паутова М.О. | ИБКСб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:    одномерные массив                                              *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Паутова Мария Олеговна | ИБКСб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*  подсчитать произведение четных элементов массива.                      *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.WriteLine(" Введите число элеметнов:  ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[len];


            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(2,9);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + "\t");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(array);
            Console.WriteLine("Произведение четных элементов = " + res);


            Console.ReadKey();
        }
    }
}