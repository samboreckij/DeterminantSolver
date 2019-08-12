using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeterninantTest
{
/// <summary>
/// Класс, хранящий размерность матрицы и метод для генерации
/// </summary>
    public static class StaticData
    {
        public static int Dimension = 10;

        public static double[,] GenerateMatrix()
        {
            int dim = StaticData.Dimension;
            double[,] matr = new double[dim, dim];
            Random rnd = new Random();
            for (int i = 0; i < dim; i++)
                for (int j = 0; j < dim; j++)
                {
                    //matr[i, j] = -50 + 100 * rnd.NextDouble();
                    //matr[i, j] = rnd.Next(-50,50);
                    matr[i, j] = 5 * rnd.NextDouble();
                }
            return matr;
        }
    }
}
