namespace MobileDevice
{
    using System;
    using System.Text;
    public class Battery
    {
        private string model;
        private int? hoursIdle;
        private int? hoursTalk;

        public Battery() : this(null, null, null, null)
        {
        }

        public Battery(string model, int? hoursIdle, int? hoursTalk, BatteryType? type)
        {
            this.model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }

        public BatteryType? Type { get; set; }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Wrong model validation!");
                }
                this.model = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Hour Idle must be a positive number!");
                }
                this.hoursIdle = value;
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
                if (value <= 0)
                {
                    throw new ArgumentException("Hours Talk must be positive number!");
                }
                this.hoursTalk = value;
            }
        }

        public override string ToString()
        {
            var batteryInfo = new StringBuilder();

            batteryInfo.AppendFormat("Battery Model - {0}{1}", this.model, Environment.NewLine);
            batteryInfo.AppendFormat("Battery Idle Time - {0} hours{1}", this.hoursIdle, Environment.NewLine);
            batteryInfo.AppendFormat("Battery Talk Time - {0} hours{1}", this.hoursTalk, Environment.NewLine);
            batteryInfo.AppendFormat("Battery Type - {0}{1}", this.Type, Environment.NewLine);

            return batteryInfo.ToString();
        }

    }
}