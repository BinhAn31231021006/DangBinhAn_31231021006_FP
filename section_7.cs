using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_1
{
    internal class Section_7
    {
        public static void Main()
        {
            Question1();

        }
        static void Question1()
        {
            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Enter columns: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] a = new int[rows, cols];
            EnterMatrixRandomly(a);
            PrintMatrix(a);
            Console.Write("Enter indexRow you want to see: ");
            int indexRow = int.Parse(Console.ReadLine());
            PrintIndexRow(a, indexRow);
            Console.Write("Enter indexCol you want to see: ");
            int indexCol = int.Parse(Console.ReadLine());
            PrintIndexCol(a, indexCol);
            Console.WriteLine("Max value of the matrix: " + MaxValueInMatrix(a));
            Console.WriteLine("Min value of the index row: " + MinValueIndexRow(a, indexRow));
            Console.WriteLine("Min value of the index col: " + MinValueIndexCol(a, indexCol));
            TransposeMatrix(a);
            Console.WriteLine("Matrix after transposing: ");
            PrintMatrix(TransposeMatrix(a));
            Console.WriteLine("Main diagonal values of the matrix: ");
            PrimaryDiagonal(a);
            Console.WriteLine("Secondary diagonal values of the matrix: ");
            SecondaryDiagonal(a);
        }
        static void EnterMatrixRandomly(int[,] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(101);
                }
            }
        }
        static void PrintMatrix(int[,] a)
        {
            Console.WriteLine("Matrix: ");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintIndexRow(int[,] a, int rowIndex)
        {
            if (rowIndex < 0 || rowIndex > a.GetLength(0) - 1)
            {
                Console.WriteLine("Khong co ban hien oi!");
            }
                
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[rowIndex, j] + " ");
            }
            Console.WriteLine();
        }
        static void PrintIndexCol(int[,] a, int colIndex)
        {
            if (colIndex < 0 || colIndex > a.GetLength(1) - 1)
            {
                Console.WriteLine("Khong co ban hien oi!");
            }
            for (int i = 0; i < a.GetLength(0); i++)
            {
                Console.WriteLine(a[i, colIndex]);
            }
        }
        static int MaxValueInMatrix(int[,] a)
        {
            int max = -1;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                    { max = a[i, j]; }
                }
            }
            return max;
        }
        static int MinValueIndexRow(int[,] a, int indexRow)
        {
            int min = 101;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if (a[indexRow, j] < min)
                    min = a[indexRow, j];
            }
            return min;
        }
        static int MinValueIndexCol(int[,] a, int indexCol)
        {
            int min = 101;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                if (a[i, indexCol] < min)
                    min = a[i, indexCol];
            }
            return min;
        }
        static int[,] TransposeMatrix(int[,] a)
        {
            int transposeRow = a.GetLength(1);
            int transposeCol = a.GetLength(0);
            int[,] table = new int[transposeRow, transposeCol];
            for (int i = 0; i < transposeRow; i++)
            {
                for (int j = 0; j < transposeCol; j++)
                {
                    table[i, j] = a[j, i];
                }
            }
            return table;
        }
        static void PrimaryDiagonal(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                        Console.Write(a[i,j] + " ");
                }
            }
            Console.WriteLine();
        }
        static void SecondaryDiagonal(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i + j == a.GetLength(0) - 1)
                        Console.Write(a[i, j] + " ");
                }
            }
        }
    }
}
