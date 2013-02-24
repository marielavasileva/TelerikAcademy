using System;


class FillMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int num = 1;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = num;
                num++;


            }
        }
        
        



        for (int col = 0; col < n; col++)
        {
            for (int row = 0; row < n; row++)
            {


                Console.Write("{0,3}", matrix[row, col]);

            }
            Console.WriteLine();

        }
        num = 1;

        Console.WriteLine();

        Console.WriteLine("b:");



        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = num;
                    num++;
                }
            }

            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = num;
                    num++;
                }
            }
            num = 1;
        }
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                Console.Write("{0,3}", matrix[col, row]);

            }
            Console.WriteLine();

        }

        Console.WriteLine("c");


        for (int row = 0; row <= n - 1; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                matrix[n - row + col - 1, col] = num;
                num++;

            }
        }

        for (int row = n - 2; row >= 0; row--)
        {
            for (int col = row; col >= 0; col--)
            {
                matrix[row - col, n - col - 1] = num;
                num++;
            }
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("d:");



        num = 1;


        int maxCol = n - 1;
        int maxRow = n - 1;
        int col1 = 0;
        int row1 = 0;
        for (num = 1; num <= n * n; )
        {

            for (int i = col1; i <= maxCol; i++)
            {
                matrix[row1, i] = num;
                num++;
            }
            row1++;
            for (int i = row1; i <= maxRow; i++)
            {
                matrix[i, maxCol] = num;
                num++;
            }
            maxCol--;
            for (int i = maxCol; i >= col1; i--)
            {
                matrix[maxRow, i] = num;
                num++;
            }
            maxRow--;
            for (int i = maxRow; i >= row1; i--)
            {
                matrix[i, col1] = num;
                num++;
            }
            col1++;
        }


        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            for (int cols = 0; cols < matrix.GetLength(1); cols++)
            {
                Console.Write("{0,4}", matrix[cols, rows]);
            }
            Console.WriteLine();
        }



    }

}