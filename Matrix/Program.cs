using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество строк в матрице: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("введите количество столбцов: ");
            int m = int.Parse(Console.ReadLine());
            int[,] random = GetRandomMatrix(n, m, 0, 20);
            WriteMatrix(random, n, m);
            Console.WriteLine("введите номер строки из существующих: ");
            int row = int.Parse(Console.ReadLine());
            int summMatrixRow = GetSummMatrixRow(random, m, row);
            Console.WriteLine(summMatrixRow);
            Console.WriteLine("введите номер столбца из существующих: ");
            int column = int.Parse(Console.ReadLine());
            int summMatrixColumn = GetSummMatrixColumn(random, n, column);
            Console.WriteLine(summMatrixColumn);
            int summMatrix = GetSummMatrix(random, n, m);
            Console.WriteLine(summMatrix);
            Console.WriteLine("введите число: ");
            int value = int.Parse(Console.ReadLine());
            bool hasValue = HasValue(random, n, m, value);
            Console.WriteLine(hasValue);
            bool rowHasValue = RowHasValue(random, n, row, value);
            Console.WriteLine(rowHasValue);
            bool columnHasValue = ColumnHasValue(random, m, column, value);
            Console.WriteLine(columnHasValue);
        }

        static int[,] GetRandomMatrix(int n, int m, int minValue, int maxValue)
        {
            Random rnd = new Random();
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next(minValue, maxValue);
                }
            }
            return matrix;
        }
        static void WriteMatrix(int[,] matrix, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static int GetSummMatrixRow(int[,] matrix, int m, int row)
        {
            int summ = 0;
            for (int i = 0; i < m; i++)
            {
                int rowValue = matrix[row, i];
                summ += rowValue;
            }
            return summ;
        }
        static int GetSummMatrixColumn(int[,] matrix, int n, int column)
        {
            int summ = 0;
            for (int i = 0; i < n; i++)
            {
                int columnValue = matrix[i, column];
                summ += columnValue;
            }
            return summ;
        }
        static int GetSummMatrix(int[,] matrix, int n, int m)
        {
            int summ = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    summ += matrix[i, j];
                }
            }
            return summ;
        }
        static bool HasValue(int[,] matrix, int n, int m, int value)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] == value)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        static bool RowHasValue(int[,] matrix, int n, int row, int value)
        {
            for (int i = 0; i < n; i++)
            {
                if (matrix[row, i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        static bool ColumnHasValue(int[,] matrix, int m, int column, int value)
        {
            for (int i = 0; i < m; i++)
            {
                if (matrix[i, column] == value)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
