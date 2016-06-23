namespace Schools.People
{
    using System;
    using System.Collections.Generic;
    using Interfaces;
    public class Student : Person, IComment
    {
        internal static List<int> uniqueClassNumbers = new List<int>();

        private int classNumber;     

        public Student(string firstName, string lastName, int classNumber) : base(firstName, lastName)
        {
            this.ClassNumber = classNumber;
        }

        public Student(string firstName, string lastName, int classNumber, string comment) : this(firstName, lastName, classNumber)
        {
            this.Comment = comment;
        }

        public string Comment { get; }

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Wrong class number validation!");
                }
                if (Student.uniqueClassNumbers.Contains(value))
                {
                    throw new ArgumentException("This class number already exists!");
                }

                this.classNumber = value;
                Student.uniqueClassNumbers.Add(value);
            }
        }
    }
}
