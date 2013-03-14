using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Task12
{
    class GSMTest
    {
        static void Main(string[] args)
        {
            GSM[] tests = new GSM[2];

            tests[0] = new GSM("Galaxy S3", "Samsung", 20, "Djanka");
            tests[1] = new GSM("C1", "Nokia", new Battery(180, 10), new Display(2, 8));


            foreach (GSM gsm in tests)
            {
                Console.WriteLine(gsm + "\n");

            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}