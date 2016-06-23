namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class StartUp
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 4.20),
                new Student("Pesho", "Peshev", 3.40),
                new Student("Mariq", "Ivanova", 5.20),
                new Student("Aleksandar", "Stoilov", 4.00),
                new Student("Nikolai", "Krustev", 3.80),
                new Student("Aleksandra", "Kovacheva", 6.00),
                new Student("Georgi", "Stoqnov", 5.76),
                new Student("Dimitar", "Georgiev", 5.01),
                new Student("Kaloqn", "Ivanov", 3.20),
                new Student("Simona", "Petrova", 5.00),
            };

            students = students
                .OrderBy(x => x.Grade)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Dancho", "Danchev", 180, 8),
                new Worker("Stoqn", "Ivanov", 200, 8),
                new Worker("Mincho", "Milchev", 100, 4),
                new Worker("Kostadin", "Kirilov", 180, 8),
                new Worker("Ivailo", "Iordanov", 250, 8),
                new Worker("Petko", "Krustev", 140, 6),
                new Worker("Kaloqn", "Monev", 160, 8),
                new Worker("Atanas", "Dimitrov", 190, 8),
                new Worker("Stilqn", "Stoilov", 170, 9),
                new Worker("Mitko", "Andonov", 300, 8)
            };

            workers = workers
                .OrderByDescending(x => x.MoneyPerHour())
                .ToList();

            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 30));
            Console.WriteLine();

            var studentsAndWorkers = new List<Human>();

            studentsAndWorkers.AddRange(students);
            studentsAndWorkers.AddRange(workers);

            studentsAndWorkers = studentsAndWorkers
                .OrderBy(x => x.FirstName)
                .ThenBy(x => x.LastName)
                .ToList();

            foreach (var human in studentsAndWorkers)
            {
                Console.WriteLine(human);
            }
        }
    }
}
