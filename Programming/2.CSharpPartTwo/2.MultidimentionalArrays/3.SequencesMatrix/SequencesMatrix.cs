using System;
using System.Collections.Generic;


class SequencesMatrix
{
    static void Main(string[] args)
    {
        
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        rows = matrix.GetLength(0);
        cols = matrix.GetLength(1);
        
        int currentLenght = 1;
        int currentRow = 1;
        int currentCol = 0;

        int bestLength = 0;


        List<string> MaxSeq = new List<string>();



        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        
     
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write("{0,5}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    ++currentLenght;
                }
                if (currentLenght == bestLength)
                {
                    MaxSeq.Add(matrix[row, col]);
                }
                else if (currentLenght > bestLength)
                {
                    bestLength = currentLenght;
                    MaxSeq.Clear();
                    MaxSeq.Add(matrix[row, col]);
                }
            }
            currentLenght = 1;
        }

        
        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    ++currentLenght;
                }
                if (currentLenght == bestLength)
                {
                    MaxSeq.Add(matrix[row, col]);
                }
                else if (currentLenght > bestLength)
                {
                    bestLength = currentLenght;
                    MaxSeq.Clear();
                    MaxSeq.Add(matrix[row, col]);
                }
            }
            currentLenght = 1;
        }

        
        for (int i = 0; i < cols - 1; i++)
        {
            for (int row = 0, col = currentCol; row < rows - 1 && col < cols - 1; row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    ++currentLenght;
                }
                if (currentLenght == bestLength)
                {
                    MaxSeq.Add(matrix[row, col]);
                }
                else if (currentLenght > bestLength)
                {
                    bestLength = currentLenght;
                    MaxSeq.Clear();
                    MaxSeq.Add(matrix[row, col]);
                }
            }
            currentCol++;
            currentLenght = 1;
        }

        
        for (int i = 0; i < rows - 1; i++)
        {
            for (int row = currentRow, col = 0; row < rows - 1 && col < cols - 1; row++, col++)
            {
                if (matrix[row, col] == matrix[row + 1, col + 1])
                {
                    ++currentLenght;
                }
                if (currentLenght == bestLength)
                {
                    MaxSeq.Add(matrix[row, col]);
                }
                else if (currentLenght > bestLength)
                {
                    bestLength = currentLenght;
                    MaxSeq.Clear();
                    MaxSeq.Add(matrix[row, col]);
                }
            }
            currentRow++;
            currentLenght = 1;
        }


        
        Console.WriteLine("Max sequence is of {0} elemets", bestLength);
        for (int i = 0; i < MaxSeq.Count; i++)
        {
            Console.Write(MaxSeq[i] + " ");
        }
        Console.WriteLine();

    }
}

