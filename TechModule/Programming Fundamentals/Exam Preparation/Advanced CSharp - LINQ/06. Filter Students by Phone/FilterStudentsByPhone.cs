﻿namespace _06.Filter_Students_by_Phone
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class FilterStudentsByPhone
    {
        static void Main(string[] args)
        {
            List<Student> listWithStudents = new List<Student>();

            var input = Console.ReadLine();
            while (input != "END")
            {
                var elements = input.Split();
                var student = new Student(elements[0], elements[1], elements[2]);
                listWithStudents.Add(student);

                input = Console.ReadLine();
            }

            var resultStudent =
                listWithStudents.Where(x => x.Number.Substring(0, 2) == "02" || x.Number.Substring(0, 5) == "+3592");

            foreach (Student student in resultStudent)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, string number)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Number = number;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Number { get; set; }
    }
}