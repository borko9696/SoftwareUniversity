namespace Problem_2.String_Length
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            string input = Console.ReadLine();
            char[] charList = input.ToCharArray();
            string newStringResult = "";

            for (int i = 0; i < 20; i++)
            {
                if (charList.Length < 20)
                {
                    if (i >= charList.Length)
                    {
                        newStringResult += new string('*', 1);
                    }
                    else
                    {
                        newStringResult += charList[i];
                    }
                }
                else
                {
                    newStringResult += charList[i];
                }
            }
            Console.WriteLine(newStringResult);
        }
    }
}