namespace _05.Students_by_Email_Domain
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class FilterStudentsByEmailDomain
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

            var resultStudent = listWithStudents.Where(x => x.Domain == "gmail.com");

            foreach (Student student in resultStudent)
            {
                Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, string mail)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Mail = mail;
        }

        public string Domain
        {
            get
            {
                return this.Mail.Split('@')[1];
            }

            set
            {
            }
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Mail { get; set; }
    }
}