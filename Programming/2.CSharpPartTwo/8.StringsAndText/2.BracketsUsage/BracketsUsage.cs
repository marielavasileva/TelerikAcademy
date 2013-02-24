using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    class BracketsUsage
    {
        static void Main()
        {
            string expresission = "(( ()))";
            bool bracket = Expression(expresission);
            Console.WriteLine(bracket);
        }

        static bool Expression(string expression)
        {
            
            char bracketFirst = '(';
            char brackerSecond = ')';
            int counter = 0;
            for (int i = 0; i < expression.Length; i++)
            {


                if (expression[i] == bracketFirst)
                {
                    counter++;
                }

                if (expression[i] == brackerSecond)
                {
                    counter--;
                }

                if (counter < 0)
                {
                    return false;
                }


            }

            if (counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
    }

