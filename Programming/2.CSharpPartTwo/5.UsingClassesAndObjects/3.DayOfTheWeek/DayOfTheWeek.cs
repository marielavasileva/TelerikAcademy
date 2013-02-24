using System;



    class Program
    {
        static void Main()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today.DayOfWeek);
            Console.WriteLine(today.ToString("ddd"));
            
        }
    }

