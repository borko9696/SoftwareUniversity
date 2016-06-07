namespace _11.Joined_Students
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class JoinedStudents
    {
        static void Main(string[] args)
        {
            List<StudentSpecialty> specialties = new List<StudentSpecialty>();
            List<Student> students = new List<Student>();

            string input = Console.ReadLine();
            while (input != "Students:")
            {
                var inputArgs = input.Split();
                var specialty = new StudentSpecialty(
                    inputArgs[0].Trim() + " " + inputArgs[1].Trim(), 
                    long.Parse(inputArgs[2].Trim()));
                specialties.Add(specialty);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "END")
            {
                var inputArgs = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                var student = new Student(
                    inputArgs[1].Trim() + " " + inputArgs[2].Trim(), 
                    long.Parse(inputArgs[0].Trim()));
                students.Add(student);
                input = Console.ReadLine();
            }

            var result =
                students.Join(
                    specialties, 
                    student => student.Number, 
                    specialty => specialty.SpecialtyNumber, 
                    (student, specialty) => new { student.Name, student.Number, specialty.SpecialtyName })
                    .OrderBy(x => x.Name);

            foreach (var obj in result)
            {
                Console.WriteLine("{0} {1} {2}", obj.Name, obj.Number, obj.SpecialtyName);
            }
        }
    }

    class StudentSpecialty
    {
        public StudentSpecialty(string specialtyName, long specialtyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.SpecialtyNumber = specialtyNumber;
        }

        public string SpecialtyName { get; set; }

        public long SpecialtyNumber { get; set; }
    }

    public class Student
    {
        public Student(string name, long number)
        {
            this.Name = name;
            this.Number = number;
        }

        public string Name { get; set; }

        public long Number { get; set; }
    }
}