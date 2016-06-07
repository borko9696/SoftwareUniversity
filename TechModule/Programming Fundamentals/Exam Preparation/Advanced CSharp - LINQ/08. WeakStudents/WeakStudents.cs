namespace _08.WeakStudents
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class WeakStudents
    {
        static void Main(string[] args)
        {
            List<Student> listWithStudents = new List<Student>();

            var input = Console.ReadLine();
            while (input != "END")
            {
                var elements = input.Split();
                var student = new Student(
                    elements[0], 
                    elements[1], 
                    new[]
                        {
                            int.Parse(elements[2]), int.Parse(elements[3]), int.Parse(elements[4]), int.Parse(elements[5])
                        });

                listWithStudents.Add(student);

                input = Console.ReadLine();
            }

            var resultStudent = listWithStudents.Where(x => x.Marks[0] <= 3 && x.Marks[1] <= 3);

            foreach (Student student in resultStudent)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int[] marks)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Marks = marks.OrderBy(x => x).ToArray();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int[] Marks { get; set; }
    }
}