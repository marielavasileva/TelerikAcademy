using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task12;

namespace Task12
{
    public class GSM
    {
        private string modelGSm = null;
        private string manufacturer = null;
        private int? price = null;
        private string owner = null;
        private Battery battery = null;
        private Display display = null;
        static GSM iPhone4S = new GSM("4S", "iPhone", 1, "Someone", new Battery("someBattery", 101, 7, BatteryType.LiIon), new Display(3, 16));
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer, string owner = null,
            Battery battery = null, Display display = null)
            : this(model, manufacturer, null, owner, battery, display)
        {
        }

        public GSM(string model, string manufacturer, Battery battery, Display display)
            : this(model, manufacturer, null, null, battery, display)
        {
        }

        public GSM(string model, string manufacturer, Battery battery)
            : this(model, manufacturer, null, null, battery, null)
        {
        }
        public GSM(string model, string manufacturer, Display display)
            : this(model, manufacturer, null, null, null, display)
        {
        }

        public GSM(string model, string manufacturer, int? price, string owner = null,
            Battery battery = null, Display display = null)
        {
            this.modelGSm = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public override string ToString()
        {
            string info = string.Format(
                "Model: {0}\n" +
                "Manufacturer: {1}\n" +
                "Price: ${2}\n" +
                "Owner:{3}\n",
                this.modelGSm, this.manufacturer, this.price ?? null, this.owner);

            if (battery != null)
            {
                info += battery.ToString();
            }

            if (display != null)
            {
                info += display.ToString();
            }

            return info;
        }

        public string Model
        {
            get { return this.modelGSm; }
            set
            {
                if (value == "")
                {
                    this.modelGSm = null;
                }
                else
                {
                    this.modelGSm = value;
                }
            }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            set
            {
                if (value == "")
                {
                    this.manufacturer = null;
                }
                else
                {
                    this.manufacturer = value;
                }
            }
        }

        public string Owner
        {
            get { return this.owner; }
            set
            {
                if (value == "")
                {
                    this.owner = null;
                }
                else
                {
                    this.owner = value;
                }
            }
        }

        public int? Price
        {
            get { return this.price; }
            set
            {
                if (value == -1)
                {
                    this.price = null;
                }
                else
                {
                    if (value < 1)
                    {
                        throw new ArgumentException("Price should be more than 1");
                    }
                    else
                    {
                        this.price = value;
                    }
                }
            }
        }

        public static string IPhone4S
        {
            get { return iPhone4S.ToString(); }
        }

        public Call CallHistory
        {
            set
            {
                callHistory.Add(value);
            }
        }

        public void ClearCallHistory()
        {
            callHistory.Clear();
        }

        public void AddCall(Call call)
        {
            callHistory.Add(call);
        }

        public void RemoveCall(Call call)
        {
            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i] == call)
                {
                    callHistory.RemoveAt(i);
                }
            }
        }

        public Decimal CallsCost(Decimal cost)
        {
            int callsLength = 0;

            for (int i = 0; i < callHistory.Count; i++)
            {
                callsLength += callHistory[i].Duration;
            }

            return (callsLength * cost) / 60;
        }

        public List<Call> getCalls()
        {
            return callHistory;
        }
    }

}