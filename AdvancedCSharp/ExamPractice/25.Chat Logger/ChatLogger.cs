namespace _19.Chat_Logger
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security;
    using System.Text;
    using System.Text.RegularExpressions;

    internal class ChatLogger
    {
        private static void Main()
        {
            var inputDate = Console.ReadLine();
            var date = Convert.ToDateTime(inputDate);

            var dict = new Dictionary<DateTime, string>();

            var input = Console.ReadLine();
            while (input != "END")
            {
                var args = Regex.Split(input, @" \/ ");
                var massage = args[0].Trim();
                var massageEncode = SecurityElement.Escape(massage);
                var dateMassage = Convert.ToDateTime(args[1].Trim());

                if (!dict.ContainsKey(dateMassage))
                {
                    dict[dateMassage] = string.Empty;
                }
                dict[dateMassage] = massageEncode;

                input = Console.ReadLine();
            }
            var sortedDict = dict.OrderBy(x => x.Key);
            var sb = new StringBuilder();
            foreach (var pair in sortedDict)
            {
                sb.AppendLine(string.Format("<div>{0}</div>", pair.Value));
            }

            var lastElement = sortedDict.Last();
            var lastDate = lastElement.Key;

            var span = date.Subtract(lastDate);

            if (span.Minutes < 1 && span.Days == 0 && span.Hours==0)
            {
                sb.AppendLine("<p>Last active: <time>a few moments ago</time></p>");
            }
            else if (span.Hours < 1 && span.Days == 0)
            {
                sb.AppendLine(string.Format("<p>Last active: <time>{0} minute(s) hour(s) ago</time></p>", span.Minutes));
            }
            else if (span.TotalHours < 24 && lastDate.ToShortDateString() == date.ToShortDateString())
            {
                sb.AppendLine(string.Format("<p>Last active: <time>{0} hour(s) ago</time></p>", span.Hours));
            }
            else if (span.TotalHours < 24 && lastDate.ToShortDateString() != date.ToShortDateString())
            {
                sb.AppendLine("<p>Last active: <time>yesterday</time></p>");
            }
            else
            {
                sb.AppendLine(string.Format("<p>Last active: <time>{0}</time></p>", lastDate.ToShortDateString()));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}