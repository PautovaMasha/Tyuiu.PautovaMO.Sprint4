using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PautovaMO.Sprint4.Task2.V18.Lib
{
    public class DataService: ISprint4Task2V18
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
                    s = s * array[i];
                }
            }
            return s;
        }
    }
}
