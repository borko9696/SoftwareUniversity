namespace _10.Array_Manipulator
{
    #region

    using System;
    using System.Collections.Generic;
    using System.Linq;

    #endregion

    class ArrayManipulator
    {
        private static void Add(List<int> array, int index, int element)
        {
            array.Insert(index, element);
        }

        private static void AddMany(List<int> array, int index, List<int> elementsToAdd)
        {
            array.InsertRange(index, elementsToAdd);
        }

        private static void Contains(List<int> array, int element)
        {
            bool exist = array.Contains(element);
            if (exist)
            {
                Console.WriteLine(array.IndexOf(element));
            }
            else
            {
                Console.WriteLine(-1);
            }
        }

        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split().Select(int.Parse).ToList();
            var listWithcommands = new List<string>();

            var input = Console.ReadLine();
            while (input != "print")
            {
                listWithcommands.Add(input);
                input = Console.ReadLine();
            }

            for (int i = 0; i < listWithcommands.Count; i++)
            {
                var inputArgs = listWithcommands[i].Split();

                switch (inputArgs[0])
                {
                    case "add":
                        Add(array, int.Parse(inputArgs[1]), int.Parse(inputArgs[2]));
                        break;
                    case "addMany":
                        var elementsToAdd = new List<int>();
                        for (int j = 2; j < inputArgs.Length; j++)
                        {
                            elementsToAdd.Add(int.Parse(inputArgs[j]));
                        }

                        AddMany(array, int.Parse(inputArgs[1]), elementsToAdd);
                        break;
                    case "contains":
                        Contains(array, int.Parse(inputArgs[1]));
                        break;
                    case "remove":
                        Remove(array, int.Parse(inputArgs[1]));
                        break;
                    case "shift":
                        Shift(array, int.Parse(inputArgs[1]));
                        break;
                    case "sumPairs":
                        array = new List<int>(SumPairs(array));
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }

            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        private static void Remove(List<int> array, int index)
        {
            array.RemoveAt(index);
        }

        private static void Shift(List<int> array, int count)
        {
            for (int counter = 0; counter < count; counter++)
            {
                int lastElement = array[0];

                for (int i = 1; i < array.Count; i++)
                {
                    int temp = array[i];
                    array[i - 1] = temp;
                }

                array[array.Count - 1] = lastElement;
            }
        }

        private static List<int> SumPairs(List<int> array)
        {
            var newList = new List<int>();

            int count = array.Count / 2;
            for (int i = 0, j = 0; j < count; i += 2, j++)
            {
                newList.Add(array[i] + array[i + 1]);
            }

            if (array.Count % 2 == 0)
            {
                return newList;
            }

            newList.Add(array[array.Count - 1]);
            return newList;
        }
    }
}