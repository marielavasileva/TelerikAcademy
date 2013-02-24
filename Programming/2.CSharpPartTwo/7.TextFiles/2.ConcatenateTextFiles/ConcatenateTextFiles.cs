using System;
using System.IO;

class ConcatenateTextFiles
{
    static void WriteToFile(StreamWriter output, string file)
    {
        using (StreamReader input = new StreamReader(file))
            for (string line; (line = input.ReadLine()) != null; )
                output.WriteLine(line);
    }

    static void Main()
    {
        string[] files = { "../../text1.txt", "../../text2" };

        using (StreamWriter output = new StreamWriter("../../output.txt"))
            foreach (string file in files)
                WriteToFile(output, file);
    }
}