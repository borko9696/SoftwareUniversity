namespace _07.To_Uppercase
{
    #region

    using System;
    using System.Text.RegularExpressions;

    #endregion

    class ToUppercase
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, "<upcase>(.*?)<\\/upcase>");

            foreach (Match match in matches)
            {
                var word = match.Groups[1].Value;
                input = Regex.Replace(input, string.Format("<upcase>({0})<\\/upcase>", word), word.ToUpper());
            }

            Console.WriteLine(input);
        }
    }
}