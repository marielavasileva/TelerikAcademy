using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class LessCharacters
    {
        static void Main()
        {
            string str = "съдържание";
            Console.WriteLine(str.Length);
            int width=20;
            string str1=str.PadRight(width, '*');
            Console.WriteLine(str1);
        }
    }

