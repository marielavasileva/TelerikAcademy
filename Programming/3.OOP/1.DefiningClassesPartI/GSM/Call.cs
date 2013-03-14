using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    public class Call
    {
        DateTime dateAndTime;
        long dialedNumber;
        int duration;

        public Call()
        {
        }
        public Call(DateTime dateAndTime, long dialedNumber, int duration)
        {
            this.dateAndTime = dateAndTime;
            this.dialedNumber = dialedNumber;
            this.duration = duration;
        }

        public int Duration
        {
            get { return duration; }
        }

        public override string ToString()
        {
            string info = String.Format(
                "{0:d/M/yyyy}\n" +
                "{1:H.mm.ss}\n" +
                "num: {2}\n" +
                "dur: {3} sec\n",
                dateAndTime, dateAndTime, dialedNumber, duration);

            return info;
        }
    }
}