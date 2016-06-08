namespace _04.Extract_Sentences
{
    #region

    using System;

    #endregion

    class ExtractSentences
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var sentences = Console.ReadLine().Split('.');

            for (int i = 0; i < sentences.Length; i++)
            {
                var sentanceWords = sentences[i].Split();
                bool exist = false;
                for (int j = 0; j < sentanceWords.Length; j++)
                {
                    var currentWord = sentanceWords[j];
                    if (currentWord == word)
                    {
                        exist = true;
                    }
                }

                if (exist)
                {
                    Console.WriteLine(sentences[i].Trim());
                }
            }
        }
    }
}