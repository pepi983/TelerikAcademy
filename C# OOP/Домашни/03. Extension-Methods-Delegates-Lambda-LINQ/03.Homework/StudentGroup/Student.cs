namespace StudentGroup
{
    using System;
    using System.Collections.Generic;
    public class Student
    {
        private string firstName;
        private string lastName;
        private int facNumber;
        private string telNumber;
        private string email;
        private int groupNumber;
        private List<int> marks = new List<int>();

        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public Student(string firstName, string lastName, int facNumber, string telNumber, int groupNumber, string email) : this(firstName, lastName)
        {
            this.FacNumber = facNumber;
            this.TelNumber = telNumber;
            this.GroupNumber = groupNumber;
            this.Email = email;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                if (value.Length < 2)
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
                if (value.Length < 2)
                {
                    throw new ArgumentException("Wrong last name validation!");
                }
                this.lastName = value;
            }
        }

        public int FacNumber
        {
            get
            {
                return this.facNumber; 
            }
            private set
            {
                if(value.ToString().Length != 6)
                {
                    throw new ArgumentException("Faculty Number must be with exactly 6 digits!");
                }
                this.facNumber = value;
            }
        }

        public string TelNumber
        {
            get
            {
                return this.telNumber;
            }
            set
            {
                if(value.Length != 10)
                {
                    throw new ArgumentException("Number must be with exactly 10 digits!");
                }
                this.telNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if(!(value.Contains("@")))
                {
                    throw new ArgumentException("Wrong email validation!");
                }
                this.email = value;
            }
        }
        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if(value < 1 || value > 4)
                {
                    throw new ArgumentException("Groups are between 1 and 4");
;                }
                this.groupNumber = value;
            }
        }
        public List<int> Marks
        {
            get
            {
                if (this.marks.Count == 0)
                {
                    throw new ArgumentException("This student haven't marks!");
                }
                return this.marks;
            }
        }

        public void AddMark(int mark)
        {
            this.marks.Add(mark);
        }
    }
}
