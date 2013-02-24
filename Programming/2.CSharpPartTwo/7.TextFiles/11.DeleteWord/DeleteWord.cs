using System;
using System.IO;
using System.Text.RegularExpressions;

class DeleteWord
{
    static void Main()
    {
        StreamReader input = new StreamReader("../../input.txt");
        StreamWriter output = new StreamWriter("../../output.txt");
        using (input)
        using (output)
            for (string line; (line = input.ReadLine()) != null; )
                output.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
    }
}