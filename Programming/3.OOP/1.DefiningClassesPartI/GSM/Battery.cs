using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd, None
    }

    public class Battery
    {
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;
        private BatteryType type;

        public Battery()
            : this(null, null, null)
        {
        }

        public Battery(string model)
            : this(model, null, null)
        {
        }

        public Battery(int? hoursIdle, int? hoursTalk)
            : this(null, hoursIdle, hoursTalk)
        {
        }

        public Battery(string model, int? hoursIdle, int? hoursTalk)
            : this(model, hoursIdle, hoursTalk, BatteryType.None)
        {
        }
        public Battery(string model, int? hoursIdle, int? hoursTalk, BatteryType type)
        {
            this.model = model;
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.type = type;
        }

        public override string ToString()
        {
            string info = string.Format(
                "\nBattery Model: {0}\n" +
                "Battery Idle Time: {1}h\n" +
                "Battery Talk Time: {2}h\n" +
                "Battery Type: {3}\n",
                this.model, this.hoursIdle, this.hoursTalk, type);

            return info;
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }

            set
            {
                if (value == -1)
                {
                    this.hoursIdle = null;
                }
                else
                {
                    if (value < 1)
                    {
                        throw new ArgumentException("Hours Idle should be greater than 1");
                    }
                    else
                    {
                        this.hoursIdle = value;
                    }
                }
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }

            set
            {
                if (value == -1)
                {
                    this.hoursTalk = null;
                }
                else
                {
                    if (value < 1)
                    {
                        throw new ArgumentException("Hours Talk should be greater than 1");
                    }
                    else
                    {
                        this.hoursTalk = value;
                    }
                }
            }
        }

        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                if (value != BatteryType.LiIon || value != BatteryType.NiCd || value != BatteryType.NiMH)
                {
                    throw new FormatException("Battery Type should be LiIon or NiCD or NiMH");
                }
                else
                {
                    this.type = value;
                }
            }
        }
    }
}