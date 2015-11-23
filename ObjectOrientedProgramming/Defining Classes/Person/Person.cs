namespace Person
{
    using System;

    public class Person
    {
        private int age;

        private string email;

        private string name;

        public Person(string name, int age, string email)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
            : this(name, age, null)
        {
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value > 100 || value < 1)
                {
                    throw new ArgumentException("Age must be an integer between 1 and 100!");
                }

                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }

            set
            {
                if (value != null)
                {
                    if (value == string.Empty || !value.Contains("@"))
                    {
                        throw new ArgumentException("Not a valid email!");
                    }
                }

                this.email = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Trim() == string.Empty || value == null)
                {
                    throw new ArgumentException("Name must have a value!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\nAge: {1}\nEmail: {2}", this.Name, this.Age, this.Email ?? "not set");
        }
    }
}