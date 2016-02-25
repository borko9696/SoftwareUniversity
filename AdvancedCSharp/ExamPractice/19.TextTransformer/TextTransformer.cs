namespace _19.TextTransformer
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class TextTransformer
    {
        private static void Main()
        {
            var input = Console.ReadLine();
            var sb = new StringBuilder();

            var list = new List<string>();
            var result = new List<string>();

            while (input != "burp")
            {
                input = Regex.Replace(input, @"\s+", " ");
                sb.Append(input);

                input = Console.ReadLine();
            }
            var readyString = sb.ToString();


            for (var i = 0; i < readyString.Length; i++)
            {
                var sb2 = new StringBuilder();
                var charAt = '\0';
                if (readyString[i] == '$')
                {
                    GetUncodeString(sb2, readyString, ref i, charAt = '$', list);
                }

                if (readyString[i] == '%')
                {
                    GetUncodeString(sb2, readyString, ref i, charAt = '%', list);
                }

                if (readyString[i] == '\'')
                {
                    GetUncodeString(sb2, readyString, ref i, charAt = '\'', list);
                }

                if (readyString[i] == '&')
                {
                    GetUncodeString(sb2, readyString, ref i, charAt = '&', list);
                }
            }


            for (var i = 0; i < list.Count; i++)
            {
                var sb3 = new StringBuilder();
                var weight = 0;
                var currentCode = list[i].Substring(1, list[i].Length - 2);
                var charCode = list[i][0];
                switch (charCode)
                {
                    case '$':
                        ConvertWeight(currentCode, sb3, result, weight = 1);
                        break;

                    case '%':
                        ConvertWeight(currentCode, sb3, result, weight = 2);
                        break;

                    case '&':
                        ConvertWeight(currentCode, sb3, result, weight = 3);
                        break;

                    case '\'':
                        ConvertWeight(currentCode, sb3, result, weight = 4);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }

        private static void GetUncodeString(StringBuilder sb2, string readyString, ref int i, char charAt,
            List<string> list)
        {
            sb2.Append(readyString[i]);
            for (var j = i + 1; j < readyString.Length; i++, j++)
            {
                if (readyString[j] != '%' && readyString[j] != '\'' && readyString[j] != '&' && readyString[j] != '$')
                {
                    sb2.Append(readyString[j]);
                }
                else if (readyString[j] == charAt && sb2.Length > 1)
                {
                    sb2.Append(readyString[j]);
                    list.Add(sb2.ToString());
                    i++;
                    break;
                }
                else
                {
                    break;
                }
            }
        }

        private static void ConvertWeight(string currentCode, StringBuilder sb3, List<string> result, int weight)
        {
            for (var j = 0; j < currentCode.Length; j++)
            {
                if (j%2 == 0)
                {
                    var charAscii = currentCode[j] + weight;
                    var newChar = (char) charAscii;
                    sb3.Append(newChar);
                }
                else
                {
                    var charAscii = currentCode[j] - weight;
                    var newChar = (char) charAscii;
                    sb3.Append(newChar);
                }
            }
            result.Add(sb3.ToString());
        }
    }
}