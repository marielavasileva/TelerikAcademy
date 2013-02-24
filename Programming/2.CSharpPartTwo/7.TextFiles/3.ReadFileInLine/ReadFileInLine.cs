using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SetNumbersToLines
{
    public class ReadFileInLine
    {
        static void SetNumbersToLinesMethod(StreamReader text1, StreamWriter newFile)
        {
            using (text1)
            {
                using (newFile)
                {
                    string line = text1.ReadLine();
                    int lineCount = 0;

                    while (line != null)
                    {
                        lineCount++;

                        newFile.Write(lineCount + " " + line);
                        newFile.WriteLine();

                        line = text1.ReadLine();

                    }

                    Console.WriteLine("Written in text2.txt");
                }
            }
        }

        static void Main()
        {
            StreamReader text1 = new StreamReader(@"..\..\text1.txt"); // Input file
            StreamWriter newFile = new StreamWriter(@"..\..\text2.txt"); // Output file

            SetNumbersToLinesMethod(text1, newFile);
        }
    }
}