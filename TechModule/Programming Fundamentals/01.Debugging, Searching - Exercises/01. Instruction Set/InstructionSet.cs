namespace _01.Instruction_Set
{
    #region

    using System;
    using System.Numerics;

    #endregion

    class InstructionSet
    {
        static void Main()
        {
            string input = Console.ReadLine();

            BigInteger result = 0;

            while (input != "END")
            {
                string[] iputArgs = input.Split(' ');

                BigInteger operandOne;
                BigInteger operandTwo;

                switch (iputArgs[0])
                {
                    case "INC":

                        operandOne = BigInteger.Parse(iputArgs[1]);
                        result = operandOne + 1;
                        break;

                    case "DEC":

                        operandOne = BigInteger.Parse(iputArgs[1]);
                        result = operandOne - 1;
                        break;

                    case "ADD":

                        operandOne = BigInteger.Parse(iputArgs[1]);
                        operandTwo = BigInteger.Parse(iputArgs[2]);
                        result = operandOne + operandTwo;
                        break;

                    case "MLA":

                        operandOne = BigInteger.Parse(iputArgs[1]);
                        operandTwo = BigInteger.Parse(iputArgs[2]);
                        result = operandOne * operandTwo;
                        break;
                }

                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }
    }
}