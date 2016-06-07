namespace _04.Sort_Students
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class SortStudents
    {
        static void Main(string[] args)
        {
            List<Student> listWithStudents = new List<Student>();

            var input = Console.ReadLine();
            while (input != "END")
            {
                var elements = input.Split();
                var student = new Student(elements[0], elements[1]);
                listWithStudents.Add(student);

                input = Console.ReadLine();
            }

            var resultStudent = listWithStudents.OrderBy(x => x.LastName).ThenByDescending(y => y.FirstName);

            foreach (Student student in resultStudent)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}