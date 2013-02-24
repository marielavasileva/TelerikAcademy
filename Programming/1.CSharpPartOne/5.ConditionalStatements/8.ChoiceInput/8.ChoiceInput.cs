using System;



    class ChoiceInput
    {
        static void Main()
        {
            Console.WriteLine("Enter your choice:");
                               Console.WriteLine("1.Integer");
                               Console.WriteLine("2.Double");
                               Console.WriteLine("3.String");
            string s2=Console.ReadLine();
            int num=int.Parse(s2);
            
            switch (num)
            {
                case 1:
                    Console.Write("Enter an integer : ");
                    string s=Console.ReadLine();
                    int number=int.Parse(s);
                    ++number;
                    Console.WriteLine("The new number is :{0}  ",number);
                    break;
                case 2:
                    Console.Write("Enter a double : ");
                    string s1 = Console.ReadLine();
                    double dNumber = double.Parse(s1);
                    ++dNumber;
                    Console.WriteLine("The new number is :{0} ",dNumber);
                    break;
                case 3:
                    Console.Write("Enter a string : ");
                    string str=Console.ReadLine();   
                    string asterics = "*";
                    str=str + asterics;
                    Console.WriteLine("The new string :{0} ",str);
                    break;
                default:
                    Console.WriteLine("Not vavid choice !");
                    break;
            }
        }
    }

