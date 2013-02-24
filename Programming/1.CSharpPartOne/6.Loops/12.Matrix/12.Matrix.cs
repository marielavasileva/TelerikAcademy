using System;



class Matrix
{
    static void Main(string[] args)
    {
        Console.Write("n= ");
        string strN = Console.ReadLine();
        int n = int.Parse(strN);
        
        for (int row = 1; row <= n; row++)
        {
            for (int col = row; col <= row+n-1 ;col++ )
            {
                Console.Write(col+"  ");
            }
            Console.WriteLine();
        }



    }
}

