using System.Net;
using Tyuiu.PautovaMO.Sprint4.Task6.V21.Lib;

namespace Tyuiu.PautovaMO.Sprint4.Task6.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил : Паутова М.О. | ИБКСб-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема:    одномерные массив                                              *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Паутова Мария Олеговна | ИБКСб-25-1                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* используя Array подсчитайте количество элементов, длина которых меньше 8*");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            var week= new string[] { "Facebook", "Twitter", "Instagram", "Snapchat", "LinkedIn", "Pinterest", "Reddit" };

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine(week[i]);
            }


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(week);
            Console.WriteLine("Колличество элементов длиной меньше 8 = "+res);



            Console.ReadKey();
        }
    }
}