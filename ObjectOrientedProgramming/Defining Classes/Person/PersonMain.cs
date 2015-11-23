namespace Person
{
    using System;

    internal class PersonMain
    {
        private static void Main(string[] args)
        {
            Person joro = new Person("Joro", 18);
            Person katya = new Person("Katya", 56, "katya@mail.bg");
            Console.WriteLine(joro);
            Console.WriteLine(katya);
        }
    }
}