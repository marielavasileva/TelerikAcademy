﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Dictionary
{
    static void Main()
    {
        string[] dictionary = { ".NET - platform for applications from Microsoft", 
                                "CLR - managed execution environment for .NET", 
                                "namespace - hierarchical - organization of classes",
                              "Java - object-oriented programming language, similar to C#",
                              "Javascript - web programming language"};
        string word = Console.ReadLine();
        foreach (string line in dictionary)
        {
            if (line.IndexOf(word + " -") == 0)
            {
                Console.WriteLine(line);
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
//        string[] dictionary = {
//            ".NET - platform for applications from Microsoft",
//            "CLR - managed execution environment for .NET",
//            "namespace - hierarchical - organization of classes"
//        };
//        string word = "namespace";

//        // TODO: Interpolation search
//        foreach (string item in dictionary)
//        {
//            var fragments = Regex.Match(item, "(.*?) - (.*)").Groups;

//            if (fragments[1].Value == word)
//            {
//                Console.WriteLine(fragments[2]);
//                return;
//            }
//        }
//    }
//}