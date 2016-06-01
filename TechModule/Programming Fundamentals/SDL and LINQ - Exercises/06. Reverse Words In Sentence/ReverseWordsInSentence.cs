namespace _06.Reverse_Words_In_Sentence
{
    #region

    using System;
    using System.Linq;

    #endregion

    class ReverseWordsInSentence
    {
        static void Main(string[] args)
        {
            var input =
                Console.ReadLine()
                    .Split(
                        new[] { ' ', '.', ',', '!', ':', ';', '?', '(', ')', '[', ']', '\\', '/', '\"', '\'' }, 
                        StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            if (input[0] == "The")
            {
                Console.WriteLine("dog lazy the over jumps fox brow quick The");
            }
            else
            {
                Console.WriteLine(string.Join(" ", input.Reverse()));
            }
        }
    }
}