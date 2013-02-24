using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string str = "Hello";
            foreach (var item in str)
            {
                Console.Write("\\u{0:X4} ",(int)item);
            }
            
        }
    }

