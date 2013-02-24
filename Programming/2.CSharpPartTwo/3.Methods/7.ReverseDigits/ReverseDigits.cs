using System;
using System.Text;


    class ReverseDigits
    {
        static string ReverseNumber(string strNumber)
        {

            StringBuilder revStr = new StringBuilder(strNumber.Length);

            for (int count = strNumber.Length - 1; count > -1; count--)
            {
                revStr.Append(strNumber[count]);
            }

            Console.Write("The reversed number is : " +revStr.ToString());

            return strNumber;
        }
        static void Main()
        {
            Console.Write("Enter a number to reverse : ");
            string strNum = Console.ReadLine();
            

           
            ReverseNumber(strNum);
        }
    }

