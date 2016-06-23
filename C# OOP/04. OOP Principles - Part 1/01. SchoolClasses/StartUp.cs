namespace Schools
{
    using System;
    using System.Collections.Generic;
    using Classes;
    using Disciplines;
    using Interfaces;
    using People;

    class StartUp
    {
        static void Main()
        {
            Discipline Chemistry = new Discipline("Chemistry", 20, 2, "Chemisty is sux!");
            Discipline Mathematics = new Discipline("Mathematics", 30, 3, "Matematic is helpfull!");
            Discipline Literature = new Discipline("Literature", 30, 3, "Literature is okay!");
            Discipline English = new Discipline("English", 20, 2, "English is very important!");


            Teacher Mendeleev = new Teacher("Pascal", "Mendeleev", "1 + 1 = h2o");
            Teacher Dimcho = new Teacher("Dimcho", "Negramotniq", "Sometimes Win Sometimes Lun");
            Teacher White = new Teacher("Walter", "White", "You Know The Business And I Know The Chemistry");

            Mendeleev.AddDiscipline(Chemistry);
            Mendeleev.AddDiscipline(Mathematics);

            Dimcho.AddDiscipline(Literature);
            Dimcho.AddDiscipline(English);

            White.AddDiscipline(Chemistry);

            Student Ivancho = new Student("Ivancho", "Ivanov", 1, "The big boss");
            Student Mariika = new Student("Mariika", "Ivanova", 2, "Ivancho's girlfriend");
            Student Jesse = new Student("Jesse", "Pinkman", 3, "Yo Bitch!");

            SchoolClass Overacheivers = new SchoolClass("1a", "Excellent");
            SchoolClass Narcos = new SchoolClass("high level", "Haisenberg team");

            Overacheivers.AddTeacher(Mendeleev);
            Overacheivers.AddTeacher(Dimcho);

            Overacheivers.AddStudent(Ivancho);
            Overacheivers.AddStudent(Mariika);

            Narcos.AddTeacher(White);
            Narcos.AddStudent(Jesse);

            School PriBatJoro = new School();

            PriBatJoro.AddClass(Overacheivers);
            PriBatJoro.AddClass(Narcos);

            List<IComment> comments = new List<IComment>()
            {
                Mendeleev, Dimcho, White, Ivancho, Mariika, Jesse, Chemistry, Mathematics, Literature, English, Overacheivers, Narcos
            };
            
            foreach (var obj in comments)
            {
                Console.WriteLine(obj.Comment);
            }
        }
    }
}
