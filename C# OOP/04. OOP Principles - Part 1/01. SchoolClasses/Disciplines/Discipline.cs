namespace Schools.Disciplines
{
    using System;
    using Interfaces;
    public class Discipline : IComment
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comment) 
            : this(name, numberOfLectures, numberOfExercises)
        {
            this.Comment = comment;
        }

        public string Comment { get; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(value.Length < 2)
                {
                    throw new ArgumentException("Wrong discipline name validation!");
                }

                this.name = value;
            }
        }

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentException("Number of Lectures can not be less than 1 !");
                }

                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if(value < 1)
                {
                    throw new ArgumentException("Number of Exercises can not be less than 1 !");
                }

                this.numberOfExercises = value;
            }
        }
    }
}
