using System;



    class SafelyCompare

    {
        static void Main()
        {
           double first = 5.3f;
           double second = 6.01f;
            bool firstSecond = (first == second);
            Console.WriteLine(firstSecond);

            double first1 = 5.00000001f ;
            double second1 = 5.00000003f;
            bool firstSecond1 = (first1 == second1);
            Console.WriteLine(firstSecond1);
        }
    }

