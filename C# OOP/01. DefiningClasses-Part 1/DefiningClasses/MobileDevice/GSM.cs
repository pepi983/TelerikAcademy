namespace MobileDevice
{
    using System;
    using System.Text;
    using System.Collections.Generic;
    public class GSM
    {
        public static GSM iPhone4S = new GSM(
            "IPhone 4S",
            "Apple",
            300,
            "Batkata",
            new Battery("Varta", 72, 4, BatteryType.LiIon),
            new Display(4, 16000000));

        private string model;
        private string manufacturer;
        private int? price;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer) : this(model, manufacturer, null, null, new Battery(), new Display())
        {
        }
        public GSM(string model, string manufacturer, int? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }

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

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Wrong manufacturer validation!");
                }
                this.manufacturer = value;
            }
        }

        public int? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price must be positive number!");
                }
                this.price = value;
            }
        }

        public static GSM Iphone4S
        {
            get
            {
                return iPhone4S;
            }
        }
        public string CallHistory
        {
            get
            {
                if (this.callHistory.Count == 0)
                {
                    return "Call history is empty!";
                }
                else
                {
                    var callInfo = new StringBuilder();

                    for (int i = 0; i < callHistory.Count; i++)
                    {
                        callInfo.AppendFormat("{0}. {1}{2}", i + 1, callHistory[i], Environment.NewLine);
                    }

                    return callInfo.ToString();
                }
            }
        }

        public void AddCall(DateTime dateTime, string phoneNumber, int duration)
        {
            this.callHistory.Add(new Call(dateTime, phoneNumber, duration));
        }
        public void AddCall(Call toAdd)
        {
            this.callHistory.Add(toAdd);
        }

        public void DeleteCall(int numberOfCall)
        {
            if (numberOfCall > this.callHistory.Count)
            {
                throw new ArgumentException("There isn't such call!");
            }

            this.callHistory.RemoveAt(numberOfCall - 1);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public void RemoveLongestCall()
        {
            int index = 0;
            int longestCallDuration = 0;

            for (int i = 0; i < callHistory.Count; i++)
            {
                if (callHistory[i].DurationInSeconds > longestCallDuration)
                {
                    index = i;
                    longestCallDuration = callHistory[i].DurationInSeconds;
                }
            }

            callHistory.RemoveAt(index);
        }
        public decimal PriceForCalls(decimal pricePerMinute)
        {
            var totalMinutes = 0;

            foreach (var call in this.callHistory)
            {
                if (call.DurationInSeconds % 60 == 0)
                {
                    totalMinutes += call.DurationInSeconds / 60;
                }
                else
                {
                    totalMinutes += call.DurationInSeconds / 60 + 1;  // price for current minute
                }
            }

            return totalMinutes * pricePerMinute;
        }
        public override string ToString()
        {
            var GSMInfo = new StringBuilder();

            GSMInfo.AppendFormat("GSM Model - {0}{1}", this.model, Environment.NewLine);
            GSMInfo.AppendFormat("Manufacturer - {0}{1}", this.manufacturer, Environment.NewLine);
            GSMInfo.AppendFormat("GSM PRICE - ${0}{1}", this.price, Environment.NewLine);
            GSMInfo.AppendFormat("Owner - {0}{1}", this.Owner, Environment.NewLine);
            GSMInfo.AppendFormat("{0}", this.Display);
            GSMInfo.AppendFormat("{0}", this.Battery);

            return GSMInfo.ToString();
        }
    }
}
