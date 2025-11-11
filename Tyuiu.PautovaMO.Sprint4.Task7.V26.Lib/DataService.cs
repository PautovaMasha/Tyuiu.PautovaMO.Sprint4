using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PautovaMO.Sprint4.Task7.V26.Lib
{
    public class DataService: ISprint4Task7V26
    {
        public int Calculate(int n, int m, string value)
        {
            int[,] matrix = new int[n, m];
            int index = 0;

            // Преобразуем строку в матрицу
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(value.Substring(index,1));
                    index++;
                }
            }
            int product = 1;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        product *= matrix[i, j];
                     
                    }
                }
            }

            return product;
        }

    }
}
