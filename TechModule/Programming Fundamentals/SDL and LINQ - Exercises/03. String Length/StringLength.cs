namespace _03.String_Length
{
    #region

    using System;

    #endregion

    class StringLength
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if (input.Length >= 20)
            {
                Console.WriteLine(input.Substring(0, 20));
            }
            else
            {
                Console.WriteLine(input + new string('*', 20 - input.Length));
            }
        }
    }
}