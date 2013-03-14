using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task12
{
    class GSMCallHistoryTest
    {
        static void showCalls(List<Call> callHistory)
        {
            foreach (Call call in callHistory)
            {
                Console.WriteLine(call.ToString());
            }
        }

        static void removeLongestCall(List<Call> callHistory, GSM tests)
        {
            Call longestCall = new Call();
            if (callHistory.Count > 0)
            {
                longestCall = callHistory[0];
            }
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (longestCall.Duration < callHistory[i].Duration)
                {
                    longestCall = callHistory[i];
                }
            }

            tests.RemoveCall(longestCall);
        }

        static void Main()
        {
            GSM[] tests = new GSM[3];
            DateTime dt = DateTime.Now;
            List<Call> callHistory = new List<Call>();

            //Creating instances of GSMs
            tests[0] = new GSM("Galaxy S2", "Samsung", 20, "Djanka");
            tests[1] = new GSM("3310", "Nokia", new Battery(180, 10), new Display(2, 8));
            tests[2] = new GSM("Q7", "Audi", 5, "MaMen", new Battery("typeR", 180, 10, BatteryType.LiIon), new Display(7, 32));

            //Adding calls to the GSMs
            tests[0].AddCall(new Call(dt, 359888888888, 37));
            tests[1].AddCall(new Call(dt, 359777777777, 24));
            tests[1].AddCall(new Call(dt.AddDays(1), 359777777666, 63));
            tests[2].AddCall(new Call(dt, 359666666666, 51));
            tests[2].AddCall(new Call(dt.AddDays(1), 359666666555, 43));
            tests[2].AddCall(new Call(dt.AddDays(2), 359666666444, 13));

            //Console color and format are moved right for easy code read!!!
            //Show calls for GSMs
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************** tests[0]");
            Console.ResetColor();
            showCalls(tests[0].getCalls());
            Console.WriteLine("{0:0.00} lv", tests[0].CallsCost(0.37M));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************** tests[1]");
            Console.ResetColor();
            showCalls(tests[1].getCalls());
            Console.WriteLine("{0:0.00} lv", tests[1].CallsCost(0.37M));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************** tests[2]");
            Console.ResetColor();
            showCalls(tests[2].getCalls());
            Console.WriteLine("{0:0.00} lv", tests[2].CallsCost(0.37M));

            //Removes the longest call
            removeLongestCall(tests[2].getCalls(), tests[2]);

            //Prints the new cost for the GSM with removed longest call
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************** tests[2] with removed longest call");
            Console.ResetColor();
            showCalls(tests[2].getCalls());
            Console.WriteLine("{0:0.00} lv", tests[2].CallsCost(0.37M));

            //Clear call history and printing it
            tests[1].ClearCallHistory();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*************** tests[1] with cleared call history");
            Console.ResetColor();
            showCalls(tests[1].getCalls());
        }
    }
}