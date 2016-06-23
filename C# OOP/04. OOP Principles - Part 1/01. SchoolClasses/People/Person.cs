namespace Schools.People
{
    using System;
    public abstract class Person
    {
        private string firstName;
        private string lastName;

        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if(value.Length < 2)
                {
                    throw new ArgumentException("Wrong name validation!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                if(value.Length < 2)
                {
                    throw new ArgumentException("Wrong lastname validation!");
                }

                this.lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return this.firstName + " " + this.LastName;
            }
        }
    }
}
