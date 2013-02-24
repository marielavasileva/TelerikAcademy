using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class MakeSum
{
    private static int[] ExtractNumbers(string expression)
    {
        string[] splitResult = expression.Split(',', ' ');
        List<int> numbers = new List<int>();
        foreach (string number in splitResult)
        {
            numbers.Add(int.Parse(number));
        }
        return numbers.ToArray();
    }
    
    
    private static int CalculateExpression(int[] numbers)
    {
        int result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            
            int nextNumber = numbers[i];
            
                result += nextNumber;
            
        }
        return result;
    }
    private static string ReadExpression()
    {
        Console.WriteLine("Enter expression:");
        string expression = Console.ReadLine();
        return expression;
    }
    static void Main()
    {
        
            string expression = ReadExpression();
            int[] numbers = ExtractNumbers(expression);
            
            int result = CalculateExpression(numbers);
            Console.WriteLine("{0} = {1}", expression, result);
        
    }
}