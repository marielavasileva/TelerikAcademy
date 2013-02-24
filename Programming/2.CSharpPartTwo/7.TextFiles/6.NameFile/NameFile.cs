using System;
using System.IO;
using System.Collections.Generic;

class NameFile
{
    static List<string> ReadNameLines()
    {
        List<string> names = new List<string>();

        using (StreamReader inputName = new StreamReader("../../names.txt"))
            for (string NameLine; (NameLine = inputName.ReadLine()) != null; )
                names.Add(NameLine);

        return names;
    }

    static void WriteNameLines(List<string> lines)
    {
        using (StreamWriter outputName = new StreamWriter("../../names1.txt"))
            foreach (string line in lines)
                outputName.WriteLine(line);
    }

    static void Main()
    {
        List<string> linesName = ReadNameLines(); 

        linesName.Sort();

        WriteNameLines(linesName);
        Console.WriteLine("Ready");
    }
}