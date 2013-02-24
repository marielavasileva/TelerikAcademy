using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


    class DeleteOddLines
    {
        static void Main(string[] args)
        {
            string firstFileName = "../../sample.txt";
            EditFile(firstFileName);
        }

        private static void EditFile(string firstFileName)
        {
            List<string> fileText = new List<string>();
            using (StreamReader textFile = new StreamReader(firstFileName))
            {
                string line = textFile.ReadLine();
                int lineNumber = 1;
                while (line != null)
                {
                    if (lineNumber % 2 != 0)
                    {
                        fileText.Add(line);
                    }
                    line = textFile.ReadLine();
                    lineNumber++;
                }
            }

            using (StreamWriter newFile = new StreamWriter(firstFileName))
            {
                for (int i = 0; i < fileText.Count; i++)
                {
                    newFile.WriteLine(fileText[i]);
                }
            }
        }
    }
