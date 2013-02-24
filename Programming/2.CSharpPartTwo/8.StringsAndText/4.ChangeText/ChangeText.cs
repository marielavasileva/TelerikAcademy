using System;
using System.Text.RegularExpressions;




class ChangeText
{
    public static string UpperCaseInTags(string textString, string tag)
    {
        

        string startTag = "<" + tag + ">";
        string endTag = "</" + tag + ">";
        while (textString.IndexOf(startTag) != -1)
        {
            int positionStartTag = textString.IndexOf(startTag);
            int positionEndTag = textString.IndexOf(endTag);
            string temp = textString.Substring(positionStartTag + startTag.Length, positionEndTag - positionStartTag - startTag.Length);
            textString = textString.Replace(startTag + temp + endTag, temp.ToUpper());
        }
        return textString;
    }

    static void Main()
    {
        string textString = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string tag = "upcase";
        Console.WriteLine(UpperCaseInTags(textString, tag));
    }
}

//class Program
//{
//    static void Main()
//    {
//        string str = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

//        Console.WriteLine(Regex.Replace(str, "<upcase>(.*?)</upcase>",m=>m.Groups[1].Value.ToUpper()));
//    }
//}