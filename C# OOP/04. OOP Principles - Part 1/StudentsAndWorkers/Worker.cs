namespace StudentsAndWorkers
{
    using System;
    public class Worker : Human
    {
        private double weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Week salary can not be negative number!");
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Work hours per day can not be negative number!");
                }

                this.workHoursPerDay = value;
            }
        }

        public double MoneyPerHour()
        {
            double moneyPerHour = this.weekSalary / (this.workHoursPerDay * 5);

            return moneyPerHour;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} with WeekSalary: ${2:F2}, WorkHoursPerDay: {3}, MoneyPerHour: ${4:F2}"
                , this.FirstName, this.LastName, this.weekSalary, this.workHoursPerDay, this.MoneyPerHour());
        }

    }
}
