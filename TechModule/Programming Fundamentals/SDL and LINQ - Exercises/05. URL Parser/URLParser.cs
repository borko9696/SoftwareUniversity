namespace _05.URL_Parser
{
    #region

    using System;
    using System.Text.RegularExpressions;

    #endregion

    class URLParser
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Regex regex = new Regex("(.*?):\\/\\/(.*?)\\/(.*)");
            Match match = regex.Match(input);

            if (match.Success)
            {
                Console.WriteLine("[protocol]=\"{0}\"", match.Groups[1].Value);
                Console.WriteLine("[server]=\"{0}\"", match.Groups[2].Value);
                Console.WriteLine("[resource]=\"{0}\"", match.Groups[3].Value);
            }
        }
    }
}