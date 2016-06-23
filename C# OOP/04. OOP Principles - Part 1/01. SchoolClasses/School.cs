namespace Schools
{
    using System;
    using System.Collections.Generic;
    using Schools.Classes;
    public class School
    {
        private List<SchoolClass> schoolClasses;

        public School()
        {
            this.schoolClasses = new List<SchoolClass>();
        }

        public List<SchoolClass> SchoolClasses
        {
            get
            {
                return this.schoolClasses;
            }
            private set
            {
                this.schoolClasses = value;
            }
        }

        public void AddClass(SchoolClass schoolClass)
        {
            this.schoolClasses.Add(schoolClass);
        }

        public void RemoveClass(SchoolClass schoolClass)
        {
            if (this.schoolClasses.Contains(schoolClass))
            {
                SchoolClass.uniqueTextIdentifiers.Remove(schoolClass.TextIdentifier);
                this.schoolClasses.Remove(schoolClass);
            }
            else
            {
                throw new ArgumentException("This class does not exist!");
            }
        }
    }
}
