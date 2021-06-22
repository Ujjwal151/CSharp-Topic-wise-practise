using System;

namespace Practise_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //jagged initialization directly ---------------------------------------------------------------------------
            //int[][] matrix = new int[][] { new int[]{ 10, 20, 30 }, new int[]{ 50, 60, 70 } };
            
            //jagged initialization by taking input --------------------------------------------------------------------
            int row = 3, col;
            int[][] matrix = new int[row][];
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.Write("Number of col : ");
                col = Convert.ToInt32(Console.ReadLine());
                int[] tempArray = new int[col];
                for (int j = 0; j < col; j++)
                {
                    tempArray[j] = Convert.ToInt32(Console.ReadLine());
                }
                matrix[i] = tempArray;
            }            
            
            //Jagged Output---------------------------------------------------------------------------------------------
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][ j] + " ");
                }
                Console.WriteLine();
            }




            //2D Array initialization Directly------------------------------------------------------------------------ -
            //int[,] matrix = new int[,] { { 10, 20, 30 }, { 50, 60, 70 } };
            
            //2D Array initialization by taking input -----------------------------------------------------------------           
            //int row = 2, col = 3;
            //for (int i = 0; i < row; i++)
            //{
            //    for (int j = 0; j < col; j++)
            //    {
            //        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            
            //2D Array Output-------------------------------------------------------------------------------------------
            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write(matrix[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
