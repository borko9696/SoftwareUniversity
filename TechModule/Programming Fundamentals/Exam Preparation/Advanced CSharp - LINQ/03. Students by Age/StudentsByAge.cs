namespace _03.Students_by_Age
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class StudentsByAge
    {
        static void Main(string[] args)
        {
            List<Student> listWithStudents = new List<Student>();

            var input = Console.ReadLine();
            while (input != "END")
            {
                var elements = input.Split();
                var student = new Student(elements[0], elements[1], int.Parse(elements[2]));
                listWithStudents.Add(student);

                input = Console.ReadLine();
            }

            var resultStudent = listWithStudents.Where(x => x.Age >= 18 && x.Age <= 24);

            foreach (Student student in resultStudent)
            {
                Console.WriteLine("{0} {1} {2}", student.FirstName, student.LastName, student.Age);
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public int Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}