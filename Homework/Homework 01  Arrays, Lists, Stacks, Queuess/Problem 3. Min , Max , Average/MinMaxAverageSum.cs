using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MinMaxAverageSum
{
    static void Main()
    {
        decimal[] arr = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        List<decimal> decimalList = new List<decimal>();
        List<int> intList = new List<int>();

        //Разделяме int стойностите и decimal стойностите на две части 
        for (int split = 0; split < arr.Length; split++)
        {
            if (arr[split]>Math.Floor(arr[split]))
            {
                decimalList.Add(arr[split]);
            }
            else if (arr[split] == Math.Floor(arr[split]))
            {
                intList.Add((int)arr[split]);
            }
        }

        decimal minDecial = 0;
        decimal maxDecimal = 0;
        decimal sumDecimal = 0;
        decimal averageDecimal = 0;

        decimalList.Sort();
        // Намираме минималната стойност от decimalList
        minDecial += decimalList[0];

        // Намираме максималната стойност от decimalList
        maxDecimal += decimalList[decimalList.Count - 1];

        // Намраме сумата на стойностите от decimalList
        for (int i = 0; i < decimalList.Count; i++)
        {
            sumDecimal += decimalList[i];
        }

        // Намираме Average на стойностите от decimalList
        averageDecimal += sumDecimal / decimalList.Count;

        int minInt = 0;
        int maxInt = 0;
        int sumInt = 0;
        int averageInt = 0;

        intList.Sort();
        // Намираме минималната стойност от intList
        minInt += intList[0];

        // Намираме максималната стойност от intList
        maxInt += intList[intList.Count - 1];
        
        // Намраме сумата на стойностите от decimalList
        for (int i = 0; i < intList.Count; i++)
        {
            sumInt += intList[i];
        }

        // Намираме Average на стойностите от decimalList
        averageInt += sumInt / intList.Count;

        // Отпечатваме резултата

        Console.WriteLine("[" + string.Join(", ", decimalList) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3}", minDecial, maxDecimal, sumDecimal, averageDecimal);
        Console.WriteLine();
        Console.WriteLine("[" + string.Join(", ", intList) + "] -> min: {0}, max: {1}, sum: {2}, avg: {3}", minInt, maxInt, sumInt, averageInt);
    }
}
