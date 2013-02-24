using System;


   class ASCIITable
    {
        static void Main()
        {
            
            Console.WriteLine("The ASCII table is :");
            for (int symbol = 0; symbol < 128; symbol++)
            {
                
                Console.Write((char)symbol); ;
            }
        }
    }

