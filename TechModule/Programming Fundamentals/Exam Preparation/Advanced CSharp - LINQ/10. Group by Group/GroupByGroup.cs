namespace _10.Group_by_Group
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class GroupByGroup
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            var input = Console.ReadLine();
            while (input != "END")
            {
                var elements = input.Split();
                var person = new Person(elements[0] + " " + elements[1], int.Parse(elements[2]));

                persons.Add(person);

                input = Console.ReadLine();
            }

            var resultPerson = persons.GroupBy(x => x.Group).OrderBy(y => y.Key);

            foreach (var group in resultPerson)
            {
                Console.Write("{0} - ", group.Key);

                var listWithPersons = new List<string>();
                foreach (var person in group)
                {
                    listWithPersons.Add(person.Name);
                }

                Console.WriteLine(string.Join(", ", listWithPersons));
            }
        }
    }

    class Person
    {
        public Person(string name, int @group)
        {
            this.Name = name;
            this.Group = @group;
        }

        public int Group { get; set; }

        public string Name { get; set; }
    }
}