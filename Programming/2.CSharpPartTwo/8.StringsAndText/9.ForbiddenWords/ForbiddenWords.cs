using System;
using System.Text.RegularExpressions;


namespace _9.ForbiddenWords
{
    class ForbiddenWords
    {

        static void Main(string[] args)
        {
            string strText="Microsoft announced its next generation PHP compiler today. "+
                "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            

            
            string replaceText1 = Regex.Replace(strText, "(CLR|PHP|Microsoft)",m=>new String('*',m.Length));
           

            Console.WriteLine(replaceText1);
            


        }
    }
}


//using System;
 
//class ReplaceWords
//{
//    static void Main()
//    {
//        string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
//        string[] forbidenwords = {"PHP", "CLR", "Microsoft" };
//        foreach (var item in forbidenwords)
//        {
//            text = text.Replace(item, new String('*', item.Length));
//        }
//        Console.WriteLine(text);
//    }
//}