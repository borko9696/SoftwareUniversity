namespace _06.Reverse_Array
{
    #region

    using System;
    using System.Linq;

    #endregion

    class ReverseArray
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split().ToArray();
            Array.Reverse(array);
            Console.WriteLine(string.Join(" ", array));
        }
    }
}