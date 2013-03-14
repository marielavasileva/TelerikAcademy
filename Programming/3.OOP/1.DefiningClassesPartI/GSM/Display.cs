using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    public class Display
    {
        private int? size;
        private int? numberOfColors;

        public Display()
            : this(null, null)
        {
        }

        public Display(int? size)
            : this(size, null)
        {
        }

        public Display(int? size, int? numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public int? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value == -1)
                {
                    this.size = null;
                }
                else
                {
                    if (value < 1 || value > 10)
                    {
                        throw new ArgumentException("Size should be between 1 and 10 and -1 if Not Available");
                    }
                    else
                    {
                        this.size = value;
                    }
                }
            }
        }

        public int? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value == -1)
                {
                    this.numberOfColors = null;
                }
                else
                {
                    if (value < 2 || value > 32)
                    {
                        throw new ArgumentException("Incorrect data!");
                    }
                    else
                    {
                        this.numberOfColors = value;
                    }
                }
            }
        }

        public override string ToString()
        {
            string info = String.Format(
                "\nDisplay Size: {0} inches\n" +
                "Display Colors: {1} bits\n",
                this.size, this.numberOfColors);

            return info;
        }
    }
}