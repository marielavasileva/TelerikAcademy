using System;



class GCD
{
    static void Main()
    {
        Console.Write("a= ");
        string strN = Console.ReadLine();
        uint a = uint.Parse(strN);
        Console.Write("b= ");
        string strM = Console.ReadLine();
        uint b = uint.Parse(strM);

        while (a != 0 && b != 0)
        {
            if (a > b) a %= b;
            else b %= a;
        }
        if (a == 0)
        {
            Console.WriteLine("GCD = {0}",b);
        }
        else
        {
            Console.WriteLine("GCD = {0}",a);
        }
    }
}

