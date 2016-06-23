namespace Schools.People
{
    using System.Collections.Generic;
    using Disciplines;
    using Interfaces;
    public class Teacher : Person, IComment
    {
        private List<Discipline> disciplines;

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
            this.disciplines = new List<Discipline>();
        }

        public Teacher(string firstName, string lastName, string comment) : base(firstName, lastName)
        {
            this.Comment = comment;
            this.disciplines = new List<Discipline>();
        }

        public string Comment { get; }
        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
            }
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.disciplines.Remove(discipline);
        }
    }
}
