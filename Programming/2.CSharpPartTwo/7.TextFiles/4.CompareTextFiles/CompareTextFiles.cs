using System;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        string text1 = @"..\..\text1.txt";
        string text2 = @"..\..\text2.txt";

        
            StreamReader input1 = new StreamReader(text1);
            StreamReader input2 = new StreamReader(text2);

            using (input2)
            {
                using (input1)
                {
                    int equalCount = 0;
                    int differentCount = 0;
                    string lineFile1 = input1.ReadLine();
                    string lineFile2 = input2.ReadLine();
                    while (lineFile1 != null && lineFile2 != null)
                    {
                        if (lineFile1.Equals(lineFile2))
                        {
                            equalCount++;
                        }
                        else
                        {
                            differentCount++;
                        }
                        lineFile1 = input1.ReadLine();
                        lineFile2 = input2.ReadLine();
                    }
                    Console.WriteLine("Equal lines: {0}", equalCount);
                    Console.WriteLine("Different lines: {0}", differentCount);
                }
            
        }
        
    }
}