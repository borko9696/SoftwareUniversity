namespace _11.Common_Strings
{
    #region

    using System;

    #endregion

    class CommonStrings
    {
        static void Main(string[] args)
        {
            var stringOne = Console.ReadLine();
            var stringTwo = Console.ReadLine();

            string result = "no";

            for (int i = 0; i < stringOne.Length; i++)
            {
                var currentStringOneChar = stringOne[i];
                for (int j = 0; j < stringTwo.Length; j++)
                {
                    var currentStringTwoChar = stringTwo[j];
                    if (currentStringOneChar == currentStringTwoChar)
                    {
                        result = "yes";
                        break;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}