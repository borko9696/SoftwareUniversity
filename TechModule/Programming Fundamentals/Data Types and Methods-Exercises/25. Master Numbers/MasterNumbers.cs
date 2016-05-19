using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Master_Numbers
{
    class MasterNumbers
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            
            for (int currentNum = 1; currentNum <= end; currentNum++)
            {
                if (IsPalindrome(currentNum) && SumOfDigits(currentNum) && ContainsEvenDigit(currentNum))
                {
                    Console.WriteLine(currentNum);
                }
            }
        }

        private static bool IsPalindrome(int num)
        {
            string sNum = num.ToString();

            for (int i = 0; i < sNum.Length; i++)
            {
                if (sNum[i] != sNum[sNum.Length - 1 - i])
                {
                    return false;
                }
            }
               

            return true;
        }

        private static bool SumOfDigits(int num)
        {
            char[] numberAsCharArray = num.ToString().ToCharArray();
            int sum = 0;
            foreach (var charNum in numberAsCharArray)
            {
                sum += int.Parse(charNum.ToString());
            }

            return sum % 7 == 0;
        }

        private static bool ContainsEvenDigit(int num)
        {
            foreach (var item in num.ToString())
            {
                if (int.Parse(item.ToString()) % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
