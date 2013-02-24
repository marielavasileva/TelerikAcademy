using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class ExtractSentences
{
    static void Main()
    {
        string strText = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string word = "in";
        string[] sentences = strText.Split('.');

        for (int i = 0; i < sentences.Length; i++)
        {
            if (Regex.Matches(sentences[i], @"\b" + word + @"\b").Count > 0)
            {
                Console.WriteLine((sentences[i] + ".").Trim());
            }
        }
    }
}


//using System;
//using System.Text.RegularExpressions;

//class Program
//{
//    static void Main()
//    {
//        string str = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
//        string word = "in";

//        foreach (Match sentence in Regex.Matches(str, @"\s*([^\.]*\b" + word + @"\b.*?\.)"))
//            Console.WriteLine(sentence.Groups[1]);
//    }
//}