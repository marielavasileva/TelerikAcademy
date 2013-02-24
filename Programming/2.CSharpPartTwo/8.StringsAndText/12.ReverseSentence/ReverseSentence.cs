using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class ReverseSentence
    {
        static void Main()
        {
            string sentence = "C# is not C++, not PHP and not Delphi!";
            StringBuilder str = new StringBuilder(sentence.Length);
            for (int index = sentence.Length-1; index >-1; index--)
            {
                str.Append(sentence[index]);
            }
            string[] sentence1 = sentence.Split(' ');

        for (int i = sentence1.Length-1; i > -1; i--)
			{
			  sentence1[i].Reverse();
             Console.Write(" "+sentence1[i].ToString()+" ");
			}
           
           
            

        }
    }

