namespace _01.Students_by_Group
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class StudentsByGroup
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

            var resultStudent = listWithStudents.Where(x => x.Group == 2).OrderBy(y => y.FirstName);

            foreach (Student student in resultStudent)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int @group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Group = @group;
        }

        public string FirstName { get; set; }

        public int Group { get; set; }

        public string LastName { get; set; }
    }
}