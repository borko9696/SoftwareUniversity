namespace CollectionOFPersons
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Wintellect.PowerCollections;

    #endregion

    internal class Program
    {
        private static void Main(string[] args)
        {
            
        }

        public class MyStructure
        {
            private Dictionary<string, SortedSet<Person>> personByDomain = new Dictionary<string, SortedSet<Person>>();

            private Dictionary<string, Person> personByEmail = new Dictionary<string, Person>();

            private Dictionary<string,SortedSet<Person>> personByNameAndTown = new Dictionary<string, SortedSet<Person>>();

            private OrderedDictionary<int, SortedSet<Person>> personByAge = new OrderedDictionary<int, SortedSet<Person>>();

            private Dictionary<string , OrderedDictionary<int, SortedSet<Person>>> personByAgeAndTown = new Dictionary<string, OrderedDictionary<int, SortedSet<Person>>>();

            public bool AddPerson(string email, string name, int age, string town)
            {
                var person = new Person(email, name, age, town);

                if (this.personByEmail.ContainsKey(email))
                {
                    return false;
                }
                this.personByEmail[email] = person;

                var domain = this.FindDomain(email);
                if (!this.personByDomain.ContainsKey(domain))
                {
                    this.personByDomain[domain] = new SortedSet<Person>();
                }
                this.personByDomain[domain].Add(person);

                var nameAndTown = this.FindNameAndTown(name, town);
                if (!this.personByNameAndTown.ContainsKey(nameAndTown))
                {
                    this.personByNameAndTown[nameAndTown] = new SortedSet<Person>();
                }
                this.personByNameAndTown[nameAndTown].Add(person);

                if (!this.personByAge.ContainsKey(age))
                {
                    this.personByAge[age] = new SortedSet<Person>();
                }
                this.personByAge[age].Add(person);

                if (!this.personByAgeAndTown.ContainsKey(town))
                {
                    this.personByAgeAndTown[town] = new OrderedDictionary<int, SortedSet<Person>>();
                }
                if (!this.personByAgeAndTown[town].ContainsKey(age))
                {
                    this.personByAgeAndTown[town].Add(age, new SortedSet<Person>());
                }
                this.personByAgeAndTown[town][age].Add(person);

                return true;
            }

            public Person FindPerson(string email)
            {
                if (!this.personByEmail.ContainsKey(email))
                {
                    return null;
                }

                return this.personByEmail[email];
            }

            public bool DeletePerson(string email)
            {
                if (!this.personByEmail.ContainsKey(email))
                {
                    return false;
                }
                var person = this.personByEmail[email];

                this.personByEmail.Remove(email);

                var domain = this.FindDomain(person.Email);
                this.personByDomain[domain].Remove(person);
                if (this.personByDomain[domain].Count == 0)
                {
                    this.personByDomain.Remove(domain);
                }

                var nameAndTown = this.FindNameAndTown(person.Name, person.Town);
                this.personByNameAndTown[nameAndTown].Remove(person);
                if (this.personByNameAndTown[nameAndTown].Count == 0)
                {
                    this.personByNameAndTown.Remove(nameAndTown);
                }

                this.personByAge[person.Age].Remove(person);
                if (this.personByAge[person.Age].Count == 0)
                {
                    this.personByAge.Remove(person.Age);
                }

                this.personByAgeAndTown[person.Town][person.Age].Remove(person);
                if (this.personByAgeAndTown[person.Town][person.Age].Count == 0)
                {
                    this.personByAgeAndTown[person.Town].Remove(person.Age);
                }
                if (this.personByAgeAndTown[person.Town].Count == 0)
                {
                    this.personByAgeAndTown.Remove(person.Town);
                }
                return true;
            }

            public IEnumerable<Person> FindPersons(string domain)
            {
                if (!this.personByDomain.ContainsKey(domain))
                {
                    return null;
                }
                var collection = this.personByDomain[domain];

                return collection;
            }

            public IEnumerable<Person> FindPersons(string name, string town)
            {
                var nameAndTown = this.FindNameAndTown(name, town);
                if (!this.personByNameAndTown.ContainsKey(nameAndTown))
                {
                    return null;
                }
                var collection = this.personByNameAndTown[nameAndTown];

                return collection;
            }

            public IEnumerable<Person> FindPersons(int startAge, int endAge)
            {
                var collection = this.personByAge.Range(startAge, true, endAge, true);

                if (!collection.Any())
                {
                    return null;
                }

                var resultCollection = new OrderedBag<Person>();
                foreach (var persons in collection)
                {
                    foreach (var person in persons.Value)
                    {
                        resultCollection.Add(person);
                    }
                }

                return resultCollection;
            }

            public IEnumerable<Person> FindPersons(int startAge, int endAge, string town)
            {
                if (!this.personByAgeAndTown.ContainsKey(town))
                {
                    return null;
                }

                var collection = this.personByAgeAndTown[town].Range(startAge, true, endAge, true);
                if (!collection.Any())
                {
                    return null;
                }

                var resultCollection = new OrderedBag<Person>();
                foreach (var persons in collection)
                {
                    foreach (var person in persons.Value)
                    {
                        resultCollection.Add(person);
                    }
                }

                return resultCollection;
            } 

            private string FindDomain(string email)
            {
                return email.Split('@')[1];
            }

            private string FindNameAndTown(string name, string town)
            {
                return name + "!" + town;
            }
        }

        public class Person : IComparable<Person>
        {
            public Person(string email, string name, int age, string town)
            {
                this.Email = email;
                this.Name = name;
                this.Age = age;
                this.Town = town;
            }

            public int Age { get; set; }

            public string Email { get; set; }

            public string Name { get; set; }

            public string Town { get; set; }

            public int CompareTo(Person other)
            {
                // if (this == other)
                // {
                // return 0;
                // }
                if (this.Age == other.Age)
                {
                    return this.Email.CompareTo(other.Email);
                }

                return this.Age.CompareTo(other.Age);
            }
        }
    }
}