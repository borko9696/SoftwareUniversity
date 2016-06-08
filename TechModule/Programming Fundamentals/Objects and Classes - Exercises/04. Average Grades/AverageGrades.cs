namespace _04.Average_Grades
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class AverageGrades
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var listWithStudents = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                var marks = new double[input.Length - 1];

                for (int j = 1, counter = 0; counter < marks.Length; counter++, j++)
                {
                    marks[counter] = double.Parse(input[j]);
                }

                var student = new Student(input[0], marks);
                listWithStudents.Add(student);
            }

            var sortedStudents =
                listWithStudents.Where(student => student.AverageMarks >= 5.00d)
                    .OrderBy(studentName => studentName.Name)
                    .ThenByDescending(studentMarks => studentMarks.AverageMarks);

            foreach (Student student in sortedStudents)
            {
                Console.WriteLine("{0} -> {1:F2}", student.Name, student.AverageMarks);
            }
        }
    }

    class Student
    {
        public Student(string name, double[] marks)
        {
            this.Name = name;
            this.Marks = marks;
        }

        public double AverageMarks
        {
            get
            {
                return this.Marks.Sum() / this.Marks.Length;
            }

            set
            {
                // ignore
            }
        }

        public double[] Marks { get; set; }

        public string Name { get; set; }
    }
}