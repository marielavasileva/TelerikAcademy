using System;
using System.Text;

class ReplaceInHTML
{
    static void Main()
    {

        string str = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";
        StringBuilder sb = new StringBuilder(str);
        sb.Replace(@"<a href=""", @"[URL=");
        sb.Replace(@"</a>", @"[/URL]");
        sb.Replace(@""">", @"]");
        Console.WriteLine(sb);
    }
}


//﻿using System;
//using System.Text.RegularExpressions;

//class Program
//{
//    static void Main()
//    {
//        string html = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

//        Console.WriteLine(Regex.Replace(html, "<a href=\"(.*?)\">(.*?)</a>", "[URL=$1]$2[/URL]"));
//    }
//}