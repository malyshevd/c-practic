using System;
using System.Linq;
using System.Text;

namespace c_practic.Extensions
{
    public static class MatrixExtension
    {
        public static string ToString<T>(this T[,] matrix, int columnSize = 10)
        {
            StringBuilder sbMatrix = new StringBuilder();
            for (int r = 0; r < matrix?.GetLength(0); r++)
            {
                if (r > 0)
                {
                    sbMatrix.AppendLine();
                }
                for (int c = 0; c < matrix?.GetLength(1); c++)
                {
                    sbMatrix.Append(matrix[r, c]?.ToString()?.ToAlignedCenter(columnSize));
                }
            }
            return sbMatrix.ToString();
        }

        public static string ToAlignedCenter(this string str, int size)
        {
            return string.Format($"{{0,-{size}}}", string.Format($"{{0,{((size + str?.Length ?? 0) / 2).ToString()}}}", str));
        }

        public static double[] CalcSLAE_ByCholesky(this double[,] matrixA, double[] resultB, out string solution, int decimals = 2)
        {
            if (matrixA == null || matrixA.GetLength(0) != matrixA.GetLength(1))
            {
                throw new ArgumentException("Для расчета нужна квадратная матрица", nameof(matrixA));
            }

            if (resultB?.Length != matrixA.GetLength(1))
            {
                throw new ArgumentException("Кол-во ответов не равно размеру матрицы", nameof(resultB));
            }

            if (decimals < 0)
            {
                decimals = 0;
            }

            int matrixSize = matrixA.GetLength(0);
            int breakLineLength = 100, columnSize = 20;
            StringBuilder sbSolution = new StringBuilder();
            sbSolution.AppendLine($"Исходная матрица A ({(!matrixA.IsSymmetricallyPositiveDefiniteMatrix() ? "НЕ" : string.Empty)} является симметричной положительно-определённой матрицей):");
            sbSolution.AppendLine(matrixA.ToString(columnSize));
            sbSolution.AppendLine("Результат B:");
            sbSolution.AppendLine(string.Join(Environment.NewLine, resultB.Select((val, i) => $"b{i + 1} = {val}").ToArray()));
            sbSolution.AppendLine(new string('-', breakLineLength));
            double[,] matrixL = new double[matrixSize, matrixSize];
            //Получаем нижнюю треугольную матрицу методом Холецкого
            matrixL[0, 0] = Math.Round(Math.Sqrt(matrixA[0, 0]), decimals);
            for (int j = 1; j < matrixSize; j++)
            {
                matrixL[j, 0] = Math.Round(matrixA[j, 0] / matrixL[0, 0], decimals);
            }

            for (int i = 0; i < matrixSize; i++)
            {
                if (i > 0)
                {
                    double sumI = 0;
                    for (int p = 0; p <= i - 1; p++)
                    {
                        sumI += Math.Round(Math.Pow(matrixL[i, p], 2), decimals);
                    }

                    matrixL[i, i] = Math.Round(Math.Sqrt(matrixA[i, i] - sumI), decimals);
                }

                if (i < matrixSize - 1)
                {
                    for (int j = i + 1; j < matrixSize; j++)
                    {
                        double sum = 0;
                        for (int p = 0; p <= i - 1; p++)
                        {
                            sum += Math.Round(matrixL[i, p] * matrixL[j, p], decimals);
                        }
                        matrixL[j, i] = Math.Round((matrixA[j, i] - sum) / matrixL[i, i], decimals);
                    }
                }
            }
            sbSolution.AppendLine("Методом Холицкого получена нижняя треугольная матрица L:");
            sbSolution.AppendLine(matrixL.ToString(columnSize));
            sbSolution.AppendLine();

            //Транспанируем полученную матрицу для получения верхней треугольной матрицы
            double[,] transpositionMatrixL = new double[matrixSize, matrixSize];
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    transpositionMatrixL[i, j] = matrixL[j, i];
                }
            }

            sbSolution.AppendLine("Транспанируем полученную матрицу для получения верхней треугольной матрицы LT:");
            sbSolution.AppendLine(transpositionMatrixL.ToString(15));
            sbSolution.AppendLine(new string('-', breakLineLength));

            double[] y = new double[matrixSize];
            double[] x = new double[matrixSize];

            sbSolution.AppendLine("Решаем систему Ly=b:");
            //Решаем систему с нижней треугольной матрицей прямой подстановкой
            y[0] = Math.Round(resultB[0] / matrixL[0, 0], decimals);
            sbSolution.AppendLine($"y1  = {y[0]}");
            for (int i = 1; i < matrixSize; i++)
            {
                double sum = 0;
                for (int j = 0; j <= i - 1; j++)
                {
                    sum += Math.Round(matrixL[i, j] * y[j], decimals);
                }
                y[i] = Math.Round((resultB[i] - sum) / matrixL[i, i], decimals);
                sbSolution.AppendLine($"y{i + 1} = {y[i]}");
            }
            sbSolution.AppendLine(new string('-', breakLineLength));
            sbSolution.AppendLine("Решаем систему LTx = y");
            //Решаем систему с верхней треугольной матрицей обратной подстановкой
            x[matrixSize - 1] = Math.Round(y[matrixSize - 1] / transpositionMatrixL[matrixSize - 1, matrixSize - 1], decimals);
            sbSolution.AppendLine($"x{matrixSize} = {x[matrixSize - 1]}");
            for (int i = matrixSize - 2; i >= 0; i--)
            {
                double sum = 0;
                for (int j = i + 1; j < matrixSize; j++)
                {
                    sum += Math.Round(transpositionMatrixL[i, j] * x[j], decimals);
                }
                x[i] = Math.Round((y[i] - sum) / transpositionMatrixL[i, i], decimals);
                sbSolution.AppendLine($"x{i + 1} = {x[i]}");
            }

            sbSolution.AppendLine(new string('-', breakLineLength));
            sbSolution.AppendLine($"Ответ: {string.Join(", ", x.Select((val, i) => $"x{i + 1} = {val}").ToArray())}");

            solution = sbSolution.ToString();

            return x;
        }
        private static int SignOfElement(int i, int j)
        {
            return (i + j) % 2 == 0 ? 1 : -1;
        }
        public static double[,] GetMinor(this double[,] matrix, int i, int j)
        {
            if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new ArgumentException("Для расчета нужна квадратная матрица", nameof(matrix));
            }
            int size = matrix.GetLength(0);
            double[,] output = new double[size - 1, size - 1];
            int x = 0, y = 0;
            for (int m = 0; m < size; m++, x++)
            {
                if (m != i)
                {
                    y = 0;
                    for (int n = 0; n < size; n++)
                    {
                        if (n != j)
                        {
                            output[x, y] = matrix[m, n];
                            y++;
                        }
                    }
                }
                else
                {
                    x--;
                }
            }
            return output;
        }

        public static double Determinant(this double[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new ArgumentException("Для расчета нужна квадратная матрица", nameof(matrix));
            }

            int n = matrix.GetLength(0);

            switch (n)
            {
                case 1:
                    return (matrix[0, 0]);
                case 2:
                    return ((matrix[0, 0] * matrix[1, 1]) - (matrix[1, 0] * matrix[0, 1]));
                default:
                    double value = 0;
                    for (int j = 0; j < n; j++)
                    {
                        double[,] minor = matrix.GetMinor(0, j);
                        value = value + matrix[0, j] * (SignOfElement(0, j) * minor.Determinant());
                    }
                    return value;
            }
        }

        public static bool CheckMatrixCornersMinorIsPositive(this double[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new ArgumentException("Для расчета нужна квадратная матрица", nameof(matrix));
            }

            int size = matrix.GetLength(0);
            bool ok = matrix.Determinant() >= 0;
            for (int i = size - 1; i > 1 && ok; i--)
            {
                ok = matrix.GetMinor(i, i).Determinant() >= 0;
            }
            ok = ok ? matrix[0, 0] >= 0 : ok;
            return ok;
        }

        public static bool IsSymmetricallyMatrix(this double[,] matrix)
        {
            if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
            {
                throw new ArgumentException("Для расчета нужна квадратная матрица", nameof(matrix));
            }
            int size = matrix.GetLength(0);
            bool ok = true;
            for (int r = 0; r < size && ok; r++)
            {
                for (int c = 0; c < size && ok; c++)
                {
                    ok = matrix[r, c] == matrix[c, r];
                }
            }
            return ok;
        }

        //Симметричная матрица положительно определена тогда и только тогда, когда все её угловые миноры положительны
        public static bool IsSymmetricallyPositiveDefiniteMatrix(this double[,] matrix)
        {
            return matrix.IsSymmetricallyMatrix() && matrix.CheckMatrixCornersMinorIsPositive();
        }
    }
}
