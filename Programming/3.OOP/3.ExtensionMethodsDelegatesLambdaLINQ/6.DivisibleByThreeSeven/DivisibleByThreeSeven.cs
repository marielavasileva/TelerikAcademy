using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _6.DivisibleByThreeSeven
{
    class DivisibleByThreeSeven
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 2, 23, 72, 21, 7, 42};
            var divisibleNumbersLambda = numbers.Where(x => (x % 21) == 0);
            Console.WriteLine("Numbers divisible by 3 and 7  Lambda expression:");
            foreach (var number in divisibleNumbersLambda)
            {
                Console.WriteLine(number);
            }

            
            var divisibleNumbersLINQ =
                from number in numbers
                where (number % 21) == 0
                select number;
            Console.WriteLine("Numbers divisible by 3 and 7 LINQ:");
            foreach (var number in divisibleNumbersLINQ)
            {
                Console.WriteLine(number);
            }
        }
    }
}
