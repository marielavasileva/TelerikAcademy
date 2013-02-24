using System;


 class StringToObject
    {
        static void Main()
        {
            string str1= "Hello";
            string str2 = "World !";
            object str3= str1+" "+str2;
            string str4 = (string)str3;
            Console.WriteLine("The first string: "+str1);
            Console.WriteLine("The second string: "+str2);
            Console.WriteLine("The strings in object type: "+str3);
            Console.WriteLine("The casting of the object type: "+str4);
        }
    }

