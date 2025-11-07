using System.Diagnostics.CodeAnalysis;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.PautovaMO.Sprint4.Task0.V29.Lib
{
    public class DataService : ISprint4Task0V29
    {
        public int GetSumOddArrEl(int[] array)
        {
            // Переменная для суммы нечетных элементов
            int sum = 0;

            // Проходим по всем элементам массива
            for (int i = 0; i < array.Length; i++)
            {
                // Проверяем, является ли элемент нечетным
                if (array[i] % 2 != 0)
                {
                    sum += array[i]; // Добавляем нечетный элемент к сумме
                }
            }
            return sum;
        }

    }
}