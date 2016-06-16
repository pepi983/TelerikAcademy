namespace MobileDevice
{
    using System;
    public class Display
    {
        private double? size;
        private int? numberOfColors;

        public Display() : this(null, null)
        {
        }
        public Display(double? size, int? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public double? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Size must be positive number!");
                }
                this.size = value;
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
                if (value <= 0)
                {
                    throw new ArgumentException("Number of Colors must be positive number!");
                }
                this.numberOfColors = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Display Size - {0} inches{1}Number of Colors - {2}{1}",
                this.size, Environment.NewLine, this.numberOfColors);
        }
    }
}

