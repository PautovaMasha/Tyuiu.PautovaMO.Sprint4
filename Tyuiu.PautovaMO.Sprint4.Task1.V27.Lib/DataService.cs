using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PautovaMO.Sprint4.Task1.V27.Lib
{
    public class DataService : ISprint4Task1V27
    {

        public int Calculate(int[] array)
        {
            // Переменная для суммы нечетных элементов
            int s = 1;

            // Проходим по всем элементам массива
            for (int i = 0; i < array.Length; i++)
            {
                // Проверяем, является ли элемент нечетным
                if (array[i] % 2 == 0)
                {
                    s= s* array[i]; 
                }
            }
            return s;
        }

    }
}
