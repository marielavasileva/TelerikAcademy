using System;



class BankAccound
{
    static void Main()
    {
        string firstName = "Ivan";
        string middleName = "Petrov";
        string lastName = "Grigorov";
        decimal sum = 11.547m;
        string bankName = "DSK-bank";
        string IBAN = "BG12458756233ALKR12";
        string BIC = "LE1231DS";
        long cardNumber1 = 157486314852;
        long cardNumber2 = 147952369782;
        long cardNumber3 = 742025886065;

        Console.WriteLine("Name : {0} {1} {2}\n",firstName,middleName,lastName);
        Console.WriteLine("Customer's sum : {0}\n",sum);
        Console.WriteLine("Bank name : {0}\n",bankName);
        Console.WriteLine("IBAN : {0}\n",IBAN);
        Console.WriteLine("BIC : {0}\n",BIC);
        Console.WriteLine("Card number : {0} \n",cardNumber1);
        Console.WriteLine("Card number : {0} \n", cardNumber2);
        Console.WriteLine("Card number : {0} \n", cardNumber3);
    }
}

