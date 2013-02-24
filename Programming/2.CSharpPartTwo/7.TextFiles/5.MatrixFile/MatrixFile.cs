using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class MatrixFile
{
    static void Main()
    {
        int[,] matrix;
        int length;
        string[] matrixRows;
        string rowStr = string.Empty;

        StreamReader readLine;

        using (readLine = new StreamReader(@"..\..\matrix.txt"))
        {
            length = int.Parse(readLine.ReadLine());
            matrix = new int[length, length];
            matrixRows = new string[length];
            for (int i = 1; i <= length; i++)
            {
                rowStr = readLine.ReadLine();
                rowStr = rowStr.Trim('\t', ' ', '\n');
                matrixRows[i - 1] = rowStr;
            }
        }

        for (int i = 0; i < matrixRows.Length; i++)
        {
            string rowContain = matrixRows[i];
            for (int j = 0, n = 0; j < rowContain.Length; j++)
            {
                if (rowContain[j] != ' ')
                {
                    matrix[i, n] = int.Parse(rowContain[j].ToString());
                    n++;
                }
            }
        }

        int maxSum = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int temp = matrix[row, col] + matrix[row, (col + 1)] +
                    matrix[(row + 1), col] + matrix[(row + 1), (col + 1)];
                if (temp > maxSum)
                {
                    maxSum = temp;
                }
            }
        }
        Console.WriteLine(maxSum);
    }
}