namespace _04.Company_Roster
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    public class CompanyRoster
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<Employee>> employees = new Dictionary<string, List<Employee>>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                decimal selary = decimal.Parse(input[1]);
                string position = input[2];
                string departmen = input[3];
                string email = "n/a";
                int age = -1;

                if (input.Length >= 4)
                {
                    for (int j = 4; j < input.Length; j++)
                    {
                        try
                        {
                            age = int.Parse(input[j]);
                        }
                        catch (Exception)
                        {
                            email = input[j];
                        }
                    }

                    Employee employee = new Employee(name, selary, position, departmen, email, age);
                    if (!employees.ContainsKey(departmen))
                    {
                        employees[departmen] = new List<Employee>();
                    }

                    employees[departmen].Add(employee);
                }
            }

            var sortedEmployees = employees.OrderByDescending(x => x.Value.Sum(y => y.selary)).First();
            var orderedEmployees = sortedEmployees.Value.OrderByDescending(x => x.selary);
            Console.WriteLine("Highest Average Salary: {0}", sortedEmployees.Key);
            foreach (var employee in orderedEmployees)
            {
                Console.WriteLine("{0} {1:f2} {2} {3}", employee.name, employee.selary, employee.email, employee.age);
            }
        }
    }

    class Employee
    {
        public int age;

        public string department = string.Empty;

        public string email = string.Empty;

        public string name = string.Empty;

        public string position = string.Empty;

        public decimal selary;

        public Employee(
            string name, 
            decimal selary, 
            string position, 
            string department, 
            string email = "n/a", 
            int age = -1)
        {
            this.name = name;
            this.selary = selary;
            this.position = position;
            this.department = department;
            this.email = email;
            this.age = age;
        }
    }
}