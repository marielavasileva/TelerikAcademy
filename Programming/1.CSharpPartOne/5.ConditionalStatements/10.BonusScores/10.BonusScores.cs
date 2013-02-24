using System;



    class BonusScores
    {
        static void Main()
        {
            Console.Write("Enter scores");
            string s = Console.ReadLine();
            int score = int.Parse(s);
            switch (score)
            {
                case 1:
                case 2:
                case 3:
                    score *= 10;
                    Console.Write("New scores : "+ score+"\n");
                    break;
                case 4:
                case 5:
                case 6:
                    score *= 100;
                    Console.Write("New scores : "+score+"\n");
                    break;
                case 7:
                case 8:
                case 9:
                    score *= 1000;
                    Console.WriteLine("New scores : "+score+"\n");
                    break;
                case 0:
                default:
                    Console.WriteLine("It is not a valid score! \n");
                    break;
            }
        }
    }

