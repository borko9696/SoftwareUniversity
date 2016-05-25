namespace _02.Last_K_Numbers_Sums
{
    #region

    using System;
    using System.Collections.Generic;

    #endregion

    class LastKNumbersSums
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int interval = int.Parse(Console.ReadLine());

            var list = new List<long>();
            list.Add(1);

            for (int i = 1; i < numbers; i++)
            {
                long sum = 0;

                if (i < interval)
                {
                    for (int j = 0; j < list.Count; j++)
                    {
                        sum += list[j];
                    }

                    list.Add(sum);
                }
                else
                {
                    for (int j = list.Count - interval; j < list.Count; j++)
                    {
                        sum += list[j];
                    }

                    list.Add(sum);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}