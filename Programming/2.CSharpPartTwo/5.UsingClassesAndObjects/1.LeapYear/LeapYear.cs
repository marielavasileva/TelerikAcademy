using System;

    class LeapYear
    {
        static void Main()
        {
            Console.Write("Enter a year to check : ");
            int year = int.Parse(Console.ReadLine());
            DateTime.IsLeapYear(year);
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("The year is leap ",year);
            }

        }
    }

