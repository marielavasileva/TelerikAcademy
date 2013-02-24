using System;


class SquareRoot
{
    static double ReadNumber(double number)
    {
        if (number < 0)
        {
            throw new System.ArgumentOutOfRangeException("");

        }

        return Math.Sqrt(number);


    }
    static void Main()
    {

        Console.Write("Enter a number : ");
        string strNum = Console.ReadLine();


        try
        {
            double numDouble = double.Parse(strNum);
            Double.Parse(strNum);


            Console.WriteLine(ReadNumber(numDouble));

        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid integer number!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("The number is too big to fit in Int32!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Number must be positive");
        }

        finally
        {
            Console.WriteLine("Good bye");
        }


    }
}




