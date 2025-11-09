using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PautovaMO.Sprint4.Task5.V18.Lib
{
    public class DataService : ISprint4Task5V18
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] res = new int[rows, cols];

            // Копируем данные и заменяем отрицательные элементы на 0
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        res[i, j] = 0;
                    }
                    else
                    {
                        res[i, j] = matrix[i, j];
                    }
                }
            }
            return res;
        }
    }
}
