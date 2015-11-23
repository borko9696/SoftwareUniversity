namespace Square_Root
{
    using System;

    internal class SquareRoot
    {
        private static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (Exception ex)
            {
                if (ex is ArgumentOutOfRangeException || ex is FormatException)
                {
                    Console.WriteLine("Invalid number");
                }
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}