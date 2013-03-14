using System;
using System.IO;
using System.Text.RegularExpressions;

class HTML
{
    static void Main()
    {
        StreamReader reader = new StreamReader(@"..\..\..\text.html");
        using (reader)
        {
            string line = string.Empty;
            MatchCollection matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");
            while ((line = reader.ReadLine()) != null)
            {
                matchProtocolAndSiteName = Regex.Matches(line, @"(?<=^|>)[^><]+?(?=<|$)");

                foreach (var word in matchProtocolAndSiteName)
                    Console.WriteLine(word);
            }
        }
    }
}



//using System;
//using System.Text.RegularExpressions;

//class Program
//{
//    static void Main()
//    {
//        string str = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";

//        foreach (var text in Regex.Matches(str, ">(.*?)<"))
//            if (!String.IsNullOrWhiteSpace(text.Groups[1].Value))
//                Console.WriteLine(text.Groups[1]);
//    }
//}