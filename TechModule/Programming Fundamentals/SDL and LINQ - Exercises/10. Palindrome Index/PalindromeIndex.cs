namespace _10.Palindrome_Index
{
    #region

    using System;

    #endregion

    class PalindromeIndex
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var test = input.ToCharArray();
            Array.Reverse(test);
            var reversedTest = new string(test);

            int removeIndex = -1;

            if (input != reversedTest)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    var word = input.Remove(i, 1);

                    var secWord = input.Remove(i, 1);

                    var charWord = secWord.ToCharArray();
                    Array.Reverse(charWord);

                    var reversedWord = new string(charWord);

                    if (reversedWord == word)
                    {
                        removeIndex = i;
                        break;
                    }
                }
            }

            Console.WriteLine(removeIndex);
        }
    }
}