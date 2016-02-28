namespace _01.Collect_Resources
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var numLines = int.Parse(Console.ReadLine());
            var material = new List<string>();
            material.Add("stone");
            material.Add("gold");
            material.Add("wood");
            material.Add("food");


            var sum = 0;

            for (var i = 0; i < numLines; i++)
            {
                var lines = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                var start = lines[0];
                var step = lines[1];

                var element = input[start];
                var taked = new List<int>();
                var tempSum = 0;
                var index = start;
                
                while (true)
                {
                   
                    var quantity = 0;
                    if (element.Contains("_"))
                    {
                        var splited = element.Split('_');
                        var mat = splited[0];

                        if (material.Contains(mat))
                        {
                            quantity += int.Parse(splited[1]);

                            tempSum += quantity;
                            taked.Add(index);
                        }
                    }
                    else
                    {
                        var mat = element;

                        if (material.Contains(mat))
                        {
                            quantity += 1;
                        }

                        tempSum += quantity;
                        taked.Add(index);
                    }


                    start += step;
                    index =  start%input.Length;
                    element = input[index];

                    if (taked.Contains(index))
                    {
                        break;
                    }
                }

                if (tempSum > sum)
                {
                    sum = tempSum;
                }
            }
            Console.WriteLine(sum);
        }
    }
}