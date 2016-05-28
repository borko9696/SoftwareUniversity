namespace _04.Elevator
{
    #region

    using System;

    #endregion

    class Elevator
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = 0;

            if (persons % capacity == 0)
            {
                courses += persons / capacity;
            }
            else
            {
                courses += persons / capacity + 1;
            }

            Console.WriteLine(courses);
        }
    }
}