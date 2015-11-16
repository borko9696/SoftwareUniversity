using System;

internal class BiggerNumber
{
    private static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else if (a < b)
        {
            return b;
        }
        else
        {
            return 0;
        }
    }

    private static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());

        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);
    }
}