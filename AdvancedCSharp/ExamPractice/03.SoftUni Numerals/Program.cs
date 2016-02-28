using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SoftUni_Numerals
{
    using System.Numerics;
    using System.Text.RegularExpressions;

    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, int>();
            dict.Add("aa", 0);
            dict.Add("aba", 1);
            dict.Add("bcc", 2);
            dict.Add("cc", 3);
            dict.Add("cdc", 4);


            var numbers = new StringBuilder();

            MatchCollection matches = Regex.Matches(input, @"aa|aba|bcc|cc|cdc");
            foreach (Match match in matches)
            {
                var num = dict[match.Groups[0].Value];
                numbers.Append(num);
            }


            BigInteger result = 0;
            var stringNum = numbers.ToString();
            for (int i = 0; i < stringNum.Length; i++)
            {
                var num = ulong.Parse(stringNum[i].ToString());
                int lenght = stringNum.Length - 1 - i;
                
                var formul = num * BigInteger.Pow(5,lenght);
                result += formul;
            }
            Console.WriteLine(result);
        }
    }
}