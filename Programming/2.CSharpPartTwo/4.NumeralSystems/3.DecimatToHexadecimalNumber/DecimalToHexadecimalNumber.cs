using System;




    class DecimalToHexadecimalNumber
    {
        static void Main()
        {
            Console.Write("Enter decimal number to convert to hexadecimal number : ");
            int number = int.Parse(Console.ReadLine());
            string hexNumber=number.ToString("X");
            Console.WriteLine("Hexadecimal number : "+hexNumber);
        }
    }

