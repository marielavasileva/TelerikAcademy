using System;

class SpiralArray
{
    static void Main()
    {
        Console.WriteLine("Enter n between 0 and 20  n= ");
        int n = int.Parse(Console.ReadLine());
        int[,] array = new int[n, n];
        int count = 1;
        int row = 0;
        int col = 0;
        int maxRow = n - 1;
        int maxCol = n - 1;
        if (n < 20)
        {
            for (count = 1; count <= n * n; )
            {

                for (int i = col; i <= maxCol; i++)
                {
                    array[row, i] = count;                               // right
                    count++;
                }
                row++;
                for (int i = row; i <= maxRow; i++)
                {
                    array[i, maxCol] = count;                             // down
                    count++;
                }
                maxCol--;
                for (int i = maxCol; i >= col; i--)
                {
                    array[maxRow, i] = count;                             //left
                    count++;
                }
                maxRow--;
                for (int i = maxRow; i >= row; i--)
                {
                    array[i, col] = count;                                //up
                    count++;
                }
                col++;
            }


            for (int rows = 0; rows < array.GetLength(0); rows++)
            {
                for (int cols = 0; cols < array.GetLength(1); cols++)
                {
                    Console.Write("{0,4}", array[rows, cols]);
                }
                Console.WriteLine();
            }

        }
    }
}