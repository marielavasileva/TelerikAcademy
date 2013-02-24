using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
public class SimpleExpressionEvaluator
{
    private static int[] ExtractNumbers(string expression)
    {
        string[] divideResult = expression.Split('+', '-','/','*');
        List<int> numbers = new List<int>();
        foreach (string number in divideResult)
        {
            numbers.Add(int.Parse(number));
        }
        return numbers.ToArray();
    }
    private static char[] ExtractOperators(string expression)
    {
        string operationsCharacters = "+-/*";
        List<char> operators = new List<char>();
        foreach (char c in expression)
        {
            if (operationsCharacters.Contains(c))
            {
                operators.Add(c);
            }
        }
        return operators.ToArray();
    }
    private static int CalculateExpression(int[] numbers,
    char[] operators)
    {
        int result = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            char operation = operators[i - 1];
            int nextNumber = numbers[i];
            if (operation == '+')
            {
                result += nextNumber;
            }
            else if (operation == '-')
            {
                result -= nextNumber;
            }
            else if (operation == '*')
            {
                result *= nextNumber;
            }
            else if (operation == '/')
            {
                result /= nextNumber;
            }
        }
        return result;
    }
    
    static void Main()
    {
        Console.WriteLine("Enter expression:");
        string expression = Console.ReadLine();
        int[] numbers = ExtractNumbers(expression);
        char[] operators = ExtractOperators(expression);
        int result = CalculateExpression(numbers, operators);
        Console.WriteLine("{0} = {1}", expression, result);
        
        
    }
}