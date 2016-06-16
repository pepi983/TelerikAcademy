namespace MobileDevice
{
    using System;
    public class Call
    {
        public Call(DateTime dateTime, string phoneNumber, int duration)
        {
            this.Date = dateTime.ToShortDateString();
            this.Time = dateTime.ToLongTimeString();
            this.DialedPhoneNumber = phoneNumber;
            this.DurationInSeconds = duration;
        }
        public string Date { get; private set; }
        public string Time { get; private set; }
        public string DialedPhoneNumber { get; private set; }
        public int DurationInSeconds { get; private set; }

        public override string ToString()
        {
            return string.Format("{0, 10}{1, 10}{2, 5} sec{3,10}",
                this.Date,
                this.Time,
                this.DurationInSeconds,
                this.DialedPhoneNumber);
        }
    }
}
