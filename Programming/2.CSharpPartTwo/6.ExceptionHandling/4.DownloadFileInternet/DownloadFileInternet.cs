using System;
using System.Net;

class DownloadFileInternet

{
    static void Main()
    {
        
        Console.Write("Enter URL address: ");
        string URL = Console.ReadLine();
        Console.Write("Enter file name: ");
        string file = Console.ReadLine();
        string address = URL + "/" + file;
        WebClient webClient1 = new WebClient();
        try
        {
            webClient1.DownloadFile(address, file);
        }
        catch (ArgumentNullException)
        {
            Console.WriteLine("The address can not be empty");
        }
        catch (WebException)
        {
            Console.WriteLine("Invalid address or empty file.");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("This method does not support simultaneous downloads.");
        }
        finally
        {
            webClient1.Dispose();
        }
    }
}