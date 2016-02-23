namespace Problem_3.Longest_Subsequence
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class LongestSubsequence
    {
        private static void Main()
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var result = new List<int>();
            
            for (int i = 0; i < list.Count; i++)
            {
                var tempList = new List<int>();
                for (int j = i; j < list.Count; j++)
                {
                    if (list[i]==list[j])
                    {
                        tempList.Add(list[j]);
                    }
                    else
                    {
                        break;
                    }
                }
                if (result.Count < tempList.Count)
                {
                    result.Clear();
                    result.AddRange(tempList);
                }
            }
            Console.WriteLine(string.Join(" ",result));
        }
    }
}