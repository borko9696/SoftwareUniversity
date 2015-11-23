namespace Enter_Numbers
{
    using System;
    using System.Collections.Generic;

    internal class EnterNumbers
    {
        private static int count = 0;

        private static List<int> list = new List<int>();

        private static void Main(string[] args)
        {
            Console.Write("Enter START number: ");
            int start = int.Parse(Console.ReadLine());
            int end;
            for (int i = 0; i < i + 1; i++)
            {
                bool test = false;
                try
                {
                    if (start < 1 || start > 89)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        test = true;
                    }
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentOutOfRangeException || ex is FormatException)
                    {
                        Console.Write("Invalid Number . Try agein !  Re-enter START number: ");
                        start = int.Parse(Console.ReadLine());
                    }
                }
                if (test)
                {
                    break;
                }
            }
            Console.Write("Enter END number: ");
            end = int.Parse(Console.ReadLine());
            for (int i = 0; i < i + 1; i++)
            {
                bool test = false;
                try
                {
                    if (end > 100 || end < start + 10)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    else
                    {
                        test = true;
                    }
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentOutOfRangeException || ex is FormatException)
                    {
                        Console.Write("Invalid Number .\nTry agein !  Re-enter END number: ");
                        end = int.Parse(Console.ReadLine());
                    }
                }
                if (test)
                {
                    break;
                }
            }

            list.Add(start);
            ReadNumber(start, end);

            Console.WriteLine();
            for (int i = 1; i < list.Count; i++)
            {
                Console.WriteLine("Number {0} : {1}", i, list[i]);
            }
        }

        private static void ReadNumber(int start, int end)
        {
            if (list.Count == 11)
            {
                return;
            }
            else
            {
                Console.Write("Enter your number: ");
                string input = Console.ReadLine();
                try
                {
                    int num = int.Parse(input);
                    if (num <= start || num >= end || num <= list[list.Count - 1])
                    {
                        throw new ArgumentException();
                    }
                    list.Add(num);
                }
                catch (Exception ex)
                {
                    if (ex is ArgumentException || ex is FormatException)
                    {
                        Console.Write("Invalid number !!!\nTry agein : ");
                        ReadNumber(start, end);
                    }
                }
                ReadNumber(start, end);
            }
        }
    }
}