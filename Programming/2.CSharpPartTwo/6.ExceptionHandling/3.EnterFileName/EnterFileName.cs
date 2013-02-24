using System;
using System.IO;
using System.Security;

class EnterFileName
{
    static void Main()
    {
        Console.Write("Enter a path of the file : ");
        string fileName = Console.ReadLine();
        ReadFile(fileName);
    }

    static void ReadFile(string fileName)
    {
        try
        {
            string fileContent = File.ReadAllText(fileName);
            Console.WriteLine("The content of the file is: ");
            Console.WriteLine(fileContent);
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("The file path cannot be found!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The file '{0}' was not found!", fileName);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The file path is enpty !");
        }
        catch (ArgumentException)
        {
            Console.WriteLine("The entered file path is not correct!");
        }
                
        catch (SecurityException)
        {
            Console.WriteLine("You don't have permission to access this file!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("Invalid file path format!");
        }
        
    }
}