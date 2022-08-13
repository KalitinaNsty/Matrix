using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static int[,] GetRandomMatrix(int minValue, int maxValue, int n, int m)
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
        static void WriteMatrix(int[,] matrix)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
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
        static int GetSummMatrixRow(int[,] matrix, int row)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
            int summ = 0;
            for (int i = 0; i < m; i++)
            {
                int rowValue = matrix[row, i];
                summ += rowValue;
            }
            return summ;
        }
        static int GetSummMatrixColumn(int[,] matrix, int column)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
            int summ = 0;
            for (int i = 0; i < n; i++)
            {
                int columnValue = matrix[i, column];
                summ += columnValue;
            }
            return summ;
        }
        static int GetSummMatrix(int[,] matrix)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
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
        static bool HasValue(int[,] matrix, int value)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
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
        static bool RowHasValue(int[,] matrix, int row, int value)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
            for (int i = 0; i < m; i++)
            {
                if (matrix[row, i] == value)
                {
                    return true;
                }
            }
            return false;
        }
        static bool ColumnHasValue(int[,] matrix, int column, int value)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
            for (int i = 0; i < n; i++)
            {
                if (matrix[i, column] == value)
                {
                    return true;
                }
            }
            return false;
        }
        static int[] GetColumn(int[,] matrix, int numberColumn)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
            int[] column = new int[n];
            for (int i = 0; i < n; i++)
            {
               column[i] = matrix[i, numberColumn];
            }
            return column;
        }
        static void WriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        static int[] GetRow(int[,] matrix, int numberRow)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
            int[] row = new int[m];
            for (int i = 0; i < m; i++)
            {
                row[i] = matrix[numberRow, i];
            }
            return row;
        }
        static int[] GetArraySummRow(int[,] matrix)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
            int[] row = new int[m];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    row[i] += matrix[i, j];
                }
            }
            return row;
        }
        static int[] GetArraySummColumn(int[,] matrix)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
            int[] colimn = new int[n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    colimn[j] += matrix[i, j];
                }             
            }
            return colimn;
        }
        static int[] ToArray(int[,] matrix)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
            int[] array = new int[matrix.Length];
            for (int i = 0, k = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    array[k] = matrix[i, j];
                    k++;
                }
            }
            return array;
        }
        static int[,] Resize(int[,] matrix, int newN, int newM)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
            int[,] newMatrix = new int[newN, newM];
            for (int i = 0; i < newN && i < n; i++)
            {
                for (int j = 0; j < newM && j < m; j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }
            return newMatrix;
        }
        static void CountRowsAndColumns(int[,] matrix, out int rows, out int columns)
        {
            rows = matrix.GetUpperBound(0) + 1; 
            columns = matrix.Length / rows;
        }
        static int[,] RemoveColumn(int[,] matrix, int column)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
            int newM = m - 1;
            int[,] newMatrix = new int[n, newM];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0, w = 0; j < m && w < newM; j++, w++)
                {
                    if (j == column)
                    {
                        j++;
                    }
                    newMatrix[i, w] = matrix[i, j];
                }
            }
            return newMatrix;
        }
        static int[,] RemoveRow(int[,] matrix, int row)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
            int newRow = n - 1;
            int[,] newMatrix = new int[newRow, m];
            for (int i = 0, t = 0; i < n && t < newRow; i++, t++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == row)
                    {
                        i++;
                    }
                    newMatrix[t, j] = matrix[i, j];
                }
            }
            return newMatrix;
        }
        static int[,] SummMatrix(int[,] matrix1, int[,] matrix2)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix1, out n, out m);
            int[,] newMatrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    newMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return newMatrix;
        }
        static int[,] AddRow(int[,] matrix)
        {
            int n = 0;
            int m = 0;
            CountRowsAndColumns(matrix, out n, out m);
            int newRow = n + 1;
            int[,] newMatrix = new int[newRow, m];
            for (int i = 0; i < n && i < newRow; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    newMatrix[i, j] = matrix[i, j];
                }
            }
            return newMatrix;
        }
    }
}
