using System;
using System.IO;
using System.Collections.Generic;
using System.Security;

//Write a program that removes from a text file all words listed 
//in given another text file. Handle all possible exceptions in 
//your methods.

class RemoveAllWordsFromListed
{
    static List<string> ReadList()
    {
        StreamReader readList = new StreamReader("..\\..\\WordList.txt");
        string word = readList.ReadLine();
        List<string> words = new List<string>();

        using (readList)
        {
            while (word != null)
            {
                words.Add(word);
                word = readList.ReadLine();
            }
        }
        return words;

    }
    static void Main()
    {
        try
        {
            StreamReader readText = new StreamReader("..\\..\\TextFile.txt");
            string line = readText.ReadLine();

            List<string> words = ReadList();
            using (readText)
            {
                while (line != null)
                {
                    for (int i = 0; i < words.Count; i++)
                    {
                        string word = words[i];
                        line = line.Replace(word, "");
                    }
                    Console.WriteLine(line);
                    line = readText.ReadLine();
                }
            }
        }
        catch (FileNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (DirectoryNotFoundException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (ArgumentNullException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (ArgumentException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (OutOfMemoryException exc)
        {
            Console.WriteLine(exc.Message);
        }
        catch (Exception exc)
        {
            Console.WriteLine(exc.Message);
        }

    }
}




//using System;
//using System.IO;
//using System.Text.RegularExpressions;
//using System.Security;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            string regex = @"\b(" + String.Join("|", File.ReadAllLines("../../words.txt")) + @")\b";

//            using (StreamReader input = new StreamReader("../../input.txt"))
//            using (StreamWriter output = new StreamWriter("../../output.txt"))
//                for (string line; (line = input.ReadLine()) != null; )
//                    output.WriteLine(Regex.Replace(line, regex, String.Empty));
//        }

//        catch (FileNotFoundException e)
//        {
//            Console.WriteLine(e.Message);
//        }

//        catch (DirectoryNotFoundException e)
//        {
//            Console.WriteLine(e.Message);
//        }

//        catch (IOException e)
//        {
//            Console.WriteLine(e.Message);
//        }

//        catch (SecurityException e)
//        {
//            Console.WriteLine(e.Message);
//        }

//        catch (UnauthorizedAccessException e)
//        {
//            Console.WriteLine(e.Message);
//        }
//    }
//}