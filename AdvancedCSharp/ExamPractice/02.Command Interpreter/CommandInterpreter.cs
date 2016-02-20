namespace _02.Command_Interpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class CommandInterpreter
    {
        private static void Main()
        {
            var array = Console.ReadLine().Split(' ').ToList();
            var input = Console.ReadLine();

            var commandList = new List<string>();

            while (input != "end")
            {
                commandList.Add(input);

                input = Console.ReadLine();
            }

            for (var i = 0; i < commandList.Count; i++)
            {
                var command = commandList[i].Split(' ');
                if (command[0] == "rollLeft")
                {
                    int numberOfRolls = int.Parse(command[1]) % array.Count;

                    var elementsToMove = array
                        .Take(numberOfRolls)
                        .ToArray();

                    array.AddRange(elementsToMove);
                    array.RemoveRange(0, numberOfRolls);

                }
                if (command[0] == "rollRight")
                {
                    int numberOfRolls = int.Parse(command[1]) % array.Count;

                    var elementsToMove = array
                        .Skip(array.Count - numberOfRolls)
                        .Take(numberOfRolls)
                        .ToArray();

                    array.InsertRange(0, elementsToMove);
                    array.RemoveRange(array.Count - numberOfRolls, numberOfRolls);
                }
                if (command[0] == "reverse")
                {
                    if (int.Parse(command[2]) < 0 || int.Parse(command[2]) > array.Count - 1 ||
                        int.Parse(command[4]) < 0 || int.Parse(command[4]) > array.Count - 1 ||
                        int.Parse(command[4]) + int.Parse(command[2]) > array.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int j = int.Parse(command[4]) + int.Parse(command[2]) - 1; j >= int.Parse(command[2]); j--)
                        {
                            sb.Append(array[j] + " ");
                        }
                        var reverse = sb.ToString().Trim().Split(' ');

                        for (int k = int.Parse(command[2]), count = 0; k < int.Parse(command[4]) + int.Parse(command[2]); count++, k++)
                        {
                            array[k] = reverse[count];
                        }
                    }
                    
                }
                if (command[0] == "sort")
                {
                    if (int.Parse(command[2]) < 0 || int.Parse(command[2]) > array.Count - 1 ||
                        int.Parse(command[4]) < 0 || int.Parse(command[4]) > array.Count - 1 ||
                        int.Parse(command[4]) + int.Parse(command[2]) > array.Count)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        StringBuilder sb = new StringBuilder();
                        for (int j = int.Parse(command[2]); j < int.Parse(command[4]) + int.Parse(command[2]); j++)
                        {
                            sb.Append(array[j] + " ");
                        }
                        var sort = sb.ToString().Trim().Split(' ');
                        Array.Sort(sort);

                        for (int k = int.Parse(command[2]), count = 0;
                            k < int.Parse(command[4]) + int.Parse(command[2]);
                            count++, k++)
                        {
                            array[k] = sort[count];
                        }
                    }
                }
            }

            Console.WriteLine("["+string.Join(", ",array)+"]");
        }
    }
}