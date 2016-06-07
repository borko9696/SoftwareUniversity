namespace _02.Students_by_F_and_L_Name
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class StudentsByFirstAndLastName
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

            var resultStudent = listWithStudents.Where(x => x.FirstName.CompareTo(x.LastName) == -1);

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