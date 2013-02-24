using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class PrintNumber
    {
        static void Main(string[] args)
        {
            string strNumber = Console.ReadLine();
            int number = int.Parse(strNumber);
            Console.WriteLine("{0,10:D}",number);
            Console.WriteLine("{0,10:X}",number);
            Console.WriteLine("{0,10:%}",number);
            Console.WriteLine("{0,10:c}",number);
            Console.WriteLine("{0,10:e0}",number);
        }
    }

