namespace Schools.Classes
{
    using System;
    using System.Collections.Generic;
    using People;
    using Interfaces;
    public class SchoolClass : IComment
    {
        internal static List<string> uniqueTextIdentifiers = new List<string>();

        private List<Student> students;
        private List<Teacher> teachers;
        private string textIdentifier;

        public SchoolClass(string textIdentifier)
        {
            this.TextIdentifier = textIdentifier;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public SchoolClass(string textIdentifier, string comment) : this(textIdentifier)
        {
            this.Comment = comment;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public string Comment { get; }

        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            private set
            {
                this.students = value;
            }
        }

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            private set
            {
                this.teachers = value;
            }
        }

        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Wrong text identifier validation!");
                }

                if (SchoolClass.uniqueTextIdentifiers.Contains(value))
                {
                    throw new ArgumentException("This text identifier already exists !");
                }

                this.textIdentifier = value;
                SchoolClass.uniqueTextIdentifiers.Add(textIdentifier);
            }
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (students.Contains(student))
            {
                Student.uniqueClassNumbers.Remove(student.ClassNumber);
                this.students.Remove(student);
            }
            else
            {
                throw new ArgumentException("This student does not exist!");
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (teachers.Contains(teacher))
            {
                this.teachers.Remove(teacher);
            }
            else
            {
                throw new ArgumentException("This teacher does not exist!");
            }
        }
    }
}
