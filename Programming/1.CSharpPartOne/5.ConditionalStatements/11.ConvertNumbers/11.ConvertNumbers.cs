using System;



class ConvertNumbers
{
    static void Main()
    {
        Console.Write("Enter hundreds : ");
        string s = Console.ReadLine();
        int hundreds = int.Parse(s);
        Console.Write("Enter decimals : ");
        string s1 = Console.ReadLine();
        int decimals = int.Parse(s1);
        Console.Write("Enter units : ");
        string s2 = Console.ReadLine();
        int units = int.Parse(s2);
        Console.Write(hundreds + "" + decimals + "" + units + " -> ");

        switch (hundreds)
        {
            case 1:
                Console.Write("one hundred ");
                break;
            case 2:
                Console.Write("two hundred ");
                break;
            case 3:
                Console.Write("three hundred ");
                break;
            case 4:
                Console.Write("four hundred ");
                break;
            case 5:
                Console.Write("five hundred ");
                break;
            case 6:
                Console.Write("six hundred ");
                break;
            case 7:
                Console.Write("seven hundred ");
                break;
            case 8:
                Console.Write("eight hundred ");
                break;
            case 9:
                Console.Write("nine hundred  ");
                break;
            case 0:
                break;
            default:
                Console.WriteLine("Not valid");
                break;


        }
        switch (decimals)
        {

            case 1:
                if ((decimals == 1)&&(hundreds!=0))
                {
                    switch (units)
                    {


                        case 1:
                            Console.Write(" and eleven ");
                            break;
                        case 2:
                            Console.Write(" and twelve ");
                            break;
                        case 3:
                            Console.Write(" and thirteen ");
                            break;
                        case 4:
                            Console.Write(" and fourteen ");
                            break;
                        case 5:
                            Console.Write(" and fifteen ");
                            break;
                        case 6:
                            Console.Write(" and sixteen ");
                            break;
                        case 7:
                            Console.Write(" and seventeen ");
                            break;
                        case 8:
                            Console.Write(" and eighteen ");
                            break;
                        case 9:
                            Console.Write(" and nineteen ");
                            break;
                        case 0:
                            Console.Write(" and ten ");
                            break;
                        default:
                            Console.WriteLine("Not valid");
                            break;

                    }
                }
                 if (hundreds == 0)
                {
                    switch (units)
                    {


                        case 1:
                            Console.Write(" eleven ");
                            break;
                        case 2:
                            Console.Write("  twelve ");
                            break;
                        case 3:
                            Console.Write(" thirteen ");
                            break;
                        case 4:
                            Console.Write(" fourteen ");
                            break;
                        case 5:
                            Console.Write(" fifteen ");
                            break;
                        case 6:
                            Console.Write(" sixteen ");
                            break;
                        case 7:
                            Console.Write("seventeen ");
                            break;
                        case 8:
                            Console.Write(" eighteen ");
                            break;
                        case 9:
                            Console.Write(" nineteen ");
                            break;
                        case 0:
                            Console.Write("  ten ");
                            break;
                        default:
                            Console.WriteLine("Not valid");
                            break;
                    }
                }

                break;
        
            case 2:
                Console.Write("  twenty ");
                {
                    if (units != 0)
                    {
                        switch (units)
                        {
                            case 0:
                                Console.Write(" and twenty ");
                                break;
                            default:
                                break;
                        }
                    }
                }


                break;
            case 3:
                Console.Write("  thirty ");
                {
                    if (units != 0)
                    {
                        switch (units)
                        {
                            case 0:
                                Console.Write(" and thirty ");
                                break;
                            default:
                                break;

                        }
                    }
                }
                break;
            case 4:
                Console.Write(" fourty ");
                {
                    if (units != 0)
                    {
                        switch (units)
                        {

                            case 0:
                                Console.Write(" and fourty ");
                                break;

                            default:
                                break;
                        }



                    }
                }
                break;

            case 5:
                Console.Write(" fifty ");
                {
                    if (units != 0)
                    {
                        switch (units)
                        {
                            case 0:
                                Console.Write(" and fifty ");
                                break;
                            default:
                                break;
                        }
                    }
                }
                break;

            case 6:
                Console.Write("  sixty ");
                {
                    if(units!=0)
                    {
                        switch (units)
                        {
                            case 0:
                                Console.Write(" and sixty ");
                                break;
                            default:
                                break;
                        }
                    }
                }
                break;

            case 7:
                Console.Write("  seventy ");
                {
                    if(units!=0)
                    {
                        switch (units)
                        {
                            case 0:
                                Console.Write(" and seventy ");
                                break;
                            default:
                                break;
                        }
                    }
                }
                break;

            case 8:
                Console.Write(" eighty ");
                {
                    if (units != 0)
                    {
                        switch (units)
                        {
                            case 0:
                                Console.Write(" and eighty ");
                                break;
                            default:
                                break;
                        }
                    }
                }
                break;

            case 9:
                Console.Write(" ninety ");
                {
                    if(units!=0)
                    {
                        switch (units)
                        {
                            case 0:
                                Console.Write(" and ninety ");
                                break;
                            default:
                                Console.WriteLine("Not valid");
                                break;
                        }
                    }
                }
                break;

            case 0:
                {
                    if (decimals == 0)
                    {
                        switch (units)
                        {
                            case 1:
                                Console.Write(" and one \n");
                                break;

                            case 2:
                                Console.Write(" and two \n");
                                break;
                            case 3:
                                Console.Write(" and three \n");
                                break;

                            case 4:
                                Console.Write(" and four \n");
                                break;
                            case 5:
                                Console.Write(" and five \n");
                                break;
                            case 6:
                                Console.Write(" and six \n");
                                break;

                            case 7:
                                Console.Write(" and seven \n");
                                break;
                            case 8:
                                Console.Write(" and eight \n");
                                break;
                            case 9:
                                Console.Write(" and nine \n");
                                break;
                            case 0:
                                if (hundreds == 0)
                                {
                                    Console.Write("zero ");
                                }
                                break;
                                
                            default:
                                break;

                        }

                    }
                }
                break;

            default:
                Console.Write("Not valid");
                break;
        }
        if((decimals!=1)&&(decimals!=0))
        {
            switch (units)
            {
                case 1:
                    Console.Write(" one \n");
                    break;

                case 2:
                    Console.Write(" two \n");
                    break;
                case 3:
                    Console.Write(" three \n");
                    break;

                case 4:
                    Console.Write(" four \n");
                    break;
                case 5:
                    Console.Write(" five \n");
                    break;
                case 6:
                    Console.Write(" six \n");
                    break;

                case 7:
                    Console.Write(" seven \n");
                    break;
                case 8:
                    Console.Write(" eight \n");
                    break;
                case 9:
                    Console.Write(" nine \n");
                    break;
                case 0:
                    if ((hundreds == 0) && (decimals == 0))
                    {
                        Console.Write(" zero ");
                    }
                    break;
                default:
                    break;
            }


        }
    }
}

