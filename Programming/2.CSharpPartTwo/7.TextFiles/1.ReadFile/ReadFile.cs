using System;
using System.IO;

class ReadFile
{
    static void Main()
    {
        string fileName = @"..\..\ReadFile.cs";
        
        Console.WriteLine("\n Line by line:");

        StreamReader reader = new StreamReader(fileName);
        using (reader)
        {
            int lineNumber = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                if (lineNumber % 2 == 0)
                {
                    Console.WriteLine(lineNumber+" "+line);
                }
                lineNumber++;
                
                line = reader.ReadLine();
            }
        }
    }
}
