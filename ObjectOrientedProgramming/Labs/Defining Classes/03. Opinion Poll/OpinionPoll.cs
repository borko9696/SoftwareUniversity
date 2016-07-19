namespace _03.Opinion_Poll
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class OpinionPoll
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> persons = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                persons.Add(new Person(input[0], int.Parse(input[1])));
            }

            foreach (var person in persons.Where(x => x.age > 30).OrderBy(x => x.name))
            {
                Console.WriteLine("{0} - {1}", person.name, person.age);
            }
        }
    }

    class Person
    {
        public int age;

        public string name = string.Empty;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}