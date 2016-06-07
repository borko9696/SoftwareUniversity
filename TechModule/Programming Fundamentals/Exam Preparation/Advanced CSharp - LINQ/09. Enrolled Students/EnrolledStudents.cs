namespace _09.Enrolled_Students
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class EnrolledStudents
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
                    new[]
                        {
                            int.Parse(elements[1]), int.Parse(elements[2]), int.Parse(elements[3]), int.Parse(elements[4])
                        });

                listWithStudents.Add(student);

                input = Console.ReadLine();
            }

            var resultStudent =
                listWithStudents.Where(
                    x => x.FacultyNumber.Substring(4, 2) == "14" || x.FacultyNumber.Substring(4, 2) == "15");

            foreach (Student student in resultStudent)
            {
                Console.WriteLine(string.Join(" ", student.Marks));
            }
        }
    }

    public class Student
    {
        public Student(string facultyNumber, int[] marks)
        {
            this.FacultyNumber = facultyNumber;
            this.Marks = marks;
        }

        public string FacultyNumber { get; set; }

        public int[] Marks { get; set; }
    }
}