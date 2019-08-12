using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MatrixOperations
{
    /// <summary>
    /// Класс, инкапсулирующий квадратную матрицу и методы для нахождения определителя. Индекс строки и столбца лежит в интервале [1,Dimension]
    /// </summary>
    public class Matrix
    {
        /// <summary>
        /// Двумерный массив для хранения матрицы
        /// </summary>
        private double[,] matrix;

        /// <summary>
        /// Размерность матрицы, целое число, больше 0.
        /// </summary>
        public int Dimension { get; set; }

        /// <summary>
        /// Доступ к элементу матрицы по номеру строки и столбца (только чтение)
        /// </summary>
        /// <param name="row">Номер строки [1,Dimension]</param>
        /// <param name="col">Номер столбца [1,Dimension]</param>
        /// <returns>Значение элемента матрицы</returns>
        public double this[int row, int col]
        {
            get
            {
                if (row > 0 && row <= Dimension && col > 0 && col <= Dimension)
                    return matrix[row - 1, col - 1];
                return double.NaN;
            }
        }

        /// <summary>
        /// Конструктор, создаёт матрицу на основе двумерного массива.
        /// </summary>
        /// <param name="matr"></param>
        public Matrix(double[,] matr)
        {
            Dimension = matr.GetLength(0);
            matrix = new double[Dimension, Dimension];
            for (int i = 0; i < matr.GetLength(0); i++)
                for (int j = 0; j < matr.GetLength(1); j++)
                    matrix[i, j] = matr[i, j];
        }

        /// <summary>
        /// Получение минора для элемента по номеру строки и столбца
        /// </summary>
        /// <param name="row">Номер строки [1,Dimension]</param>
        /// <param name="col">Номер столбца [1,Dimension]</param>
        /// <returns>Минор матрицы</returns>
        public double Minor(int row, int col)
        {
            double[,] minor = new double[Dimension - 1, Dimension - 1];
            int di = 0, dj = 0;
            for (int ki = 0; ki < Dimension - 1; ki++)
            {
                if (ki == row - 1) di = 1;
                dj = 0;
                for (int kj = 0; kj < Dimension - 1; kj++)
                {
                    if (kj == col - 1) dj = 1;
                    minor[ki, kj] = matrix[ki + di, kj + dj];
                }
            }
            return new Matrix(minor).Determinant();
        }

        /// <summary>
        /// Свойство возвращающее определитель матрицы, найденный методом разложения по строке i=1
        /// </summary>
        /// <returns></returns>
        public double Determinant()
        {

            if (Dimension == 2)
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            double sum = 0;
            for (int j = 0; j < Dimension; j++)
                sum += Math.Pow(-1, 1 + (j + 1)) * matrix[0, j] * Minor(1, j + 1);
            return sum;

        }

        /// <summary>
        /// Свойство возвращающее определитель матрицы, найденный методом разложения по строке i=1, параллельный алгоритм
        /// </summary>
        /// <returns></returns>
        public double DeterminantP()
        {

            if (Dimension == 2)
                return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
            double[] sum = new double[Dimension];
            int numberOfProcessors = Environment.ProcessorCount;
            ParallelOptions pOptions = new ParallelOptions()
            {
                MaxDegreeOfParallelism = numberOfProcessors
            };
            Parallel.For(0, Dimension, pOptions, j =>
              {
                  sum[j] = Math.Pow(-1, 1 + (j + 1)) * matrix[0, j] * Minor(1, j + 1);
              });
            return sum.Sum();

        }
    }
}
