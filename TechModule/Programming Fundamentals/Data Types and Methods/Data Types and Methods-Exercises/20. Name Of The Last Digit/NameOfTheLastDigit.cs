using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Name_Of_The_Last_Digit
{
    class NameOfTheLastDigit
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(NameOfLastDigit(number));
        }

        private static string NameOfLastDigit(string num)
        {
            string lastDigit = num[num.Length - 1].ToString();

            switch (lastDigit)
            {
                case "0":
                    return "zero";
                case "1":
                    return "one";
                case "2":
                    return "two";
                case "3":
                    return "three";
                case "4":
                    return "four";
                case "5":
                    return "five";
                case "6":
                    return "six";
                case "7":
                    return "seven";
                case "8":
                    return "eight";
                case "9":
                    return "nine";
                default:
                    return "Error";
            }
        }
    }
}
