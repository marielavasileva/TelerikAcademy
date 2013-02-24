using System;
using System.Text;



class ReverseString
{
    static void Main()
    {
        string str = "sample";

        StringBuilder revStr = new StringBuilder(str.Length);

        for (int count = str.Length - 1; count > -1; count--)
        { 
            revStr.Append(str[count]);
        }

        Console.WriteLine(revStr.ToString());

    }
}

