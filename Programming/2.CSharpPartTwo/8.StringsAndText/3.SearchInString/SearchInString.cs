using System;



class SearchInString
{
    static void Main()
    {
        Console.Write("Enter a string : ");
        string str = Console.ReadLine();
        Console.Write("Enter what you want to find : ");
        string exp = Console.ReadLine();
        str = str.ToLower();
        int index = str.IndexOf(exp);
        int counter = 0;
        while (index != -1)
        {

            index = str.IndexOf(exp, index + 1);
            counter++;
            Console.WriteLine("The string {0} is found in {1} , {2} times", exp, index, counter);

        }
        Console.WriteLine("Summary {0} times. ", counter);







    }
}

