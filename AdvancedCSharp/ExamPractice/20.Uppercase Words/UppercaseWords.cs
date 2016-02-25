namespace _20.Uppercase_Words
{
    using System;
    using System.Linq;
    using System.Security;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class UppercaseWords
    {
        private static void Main()
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();
            while (input != "END")
            {
                sb.AppendLine(input);

                input = Console.ReadLine();
            }

            MatchCollection matches = Regex.Matches(sb.ToString(), @"\b\d*[A-Z]+\d*[A-Z]*\d*\b");

            string output = sb.ToString();

            foreach (Match match in matches)
            {
                var item = match.Groups[0].Value;
                var element = Regex.Replace(item, @"\d+", String.Empty);
                var charElement = element.ToCharArray();
                Array.Reverse(charElement);
                var reversedElement = new string(charElement);

                var readyString = String.Empty;
                if (element == reversedElement)
                {
                    for (int i = 0; i < item.Length; i++)
                    {
                        if (char.IsNumber(item[i]))
                        {
                            readyString += item[i].ToString();
                        }
                        else
                        {
                            readyString += item[i].ToString() + item[i].ToString();
                        }
                    }
                }
                else
                {
                    readyString = reversedElement;
                }

                output = Regex.Replace(output, string.Format(@"\b{0}\b",item), readyString).Trim();
            }
            var security = SecurityElement.Escape(output);
            Console.WriteLine(security);
        }
    }
}