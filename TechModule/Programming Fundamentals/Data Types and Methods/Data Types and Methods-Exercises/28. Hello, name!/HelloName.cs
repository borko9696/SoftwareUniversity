namespace _18.Hello__name_
{
    using System;

    class HelloName
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Hello(name);
        }

        private static void Hello(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
