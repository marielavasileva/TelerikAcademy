using System;

class Alphabet
{
    static void Main()
    {
        char[] alphabet = new char[27]; 
        int valueOfLetter = 65; //ascii code of' A'
        
        for (int i = 1; i < 27; i++)
        {
            alphabet[i] = (char)valueOfLetter;
            valueOfLetter++;
        }

        Console.WriteLine("Enter a word :");

        string word = Console.ReadLine().ToUpper();
        
        foreach (char letter in word)
        {
            for (int i = 1; i < 27; i++)
            {
                if (alphabet[i] == letter)
                {
                    Console.WriteLine(" {0} is {1} ", letter, i);
                    break;
                }
            }
        }
    }
}