using System;



class ReadNumbers
{
    static int ReadNumber(int start, int end, int number)
    {
        int n = 1;
        Console.Write("Please enter number {0}: ", number);
        n = int.Parse(Console.ReadLine());
        if (n < start || n > end)
        {
            throw new System.ArgumentOutOfRangeException();
        }
        return n;
    }
    static void Main()
    {
        
        int n = 1;
        try
        {
            for (int i = 1; i <= 10; i++)
            {
                n = ReadNumber(n, 100, i);
            }
        }
        catch (System.FormatException) 
        {
            Console.WriteLine("Not an integer number.");
        }
        catch (System.OverflowException)
        {
            Console.WriteLine("Not in the scope of integer.");
        }
        catch (System.ArgumentNullException) 
        {
            Console.WriteLine("Null is not an integer number.");
        }
        catch (System.ArgumentOutOfRangeException) 
        {
            Console.WriteLine("The entered number is not in range."); 
        }
    }
}