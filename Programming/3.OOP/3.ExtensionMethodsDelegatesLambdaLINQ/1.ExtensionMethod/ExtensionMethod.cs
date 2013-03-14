using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1.ExtensionMethod
{
    public static class ExtensionMethod
    {
        public static StringBuilder Substring(this  StringBuilder str1,int index, int length)
        {
            StringBuilder str = new StringBuilder();

           

            return new StringBuilder(str1.ToString().Substring(index, length));
        }

        
    }


     class StringBuilderDemo
    {
        static void Main()
        {
            int index=6;
            int lenght=7;
            StringBuilder sb = new StringBuilder();
            sb.Append("some text goes here");

            StringBuilder sbSplit = sb.Substring(index,lenght);
            Console.WriteLine(sbSplit.ToString());
            
        }
    }
}

