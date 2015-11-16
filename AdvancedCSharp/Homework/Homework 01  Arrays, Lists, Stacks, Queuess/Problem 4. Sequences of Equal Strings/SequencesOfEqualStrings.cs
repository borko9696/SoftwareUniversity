using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SequencesOfEqualStrings
{
    static void Main()
    {
        string[] arr = Console.ReadLine().Split(' ');
        for (int i = 0; i < arr.Length; i++)
        {
            if (i==arr.Length-1)
	        {
                if (arr[i-1]==arr[i])
                {
                    Console.Write("{0} ",arr[i]);
                }
                else
                {
                    Console.WriteLine("{0}",arr[i]);
                }
	        }
            else if (arr[i]!=arr[i+1])
            {
                Console.WriteLine("{0}", arr[i]);
            }
            else if (arr[i]==arr[i+1])
            {
                Console.Write("{0} ", arr[i]);
            }
            
        }
        Console.WriteLine();
    }
}
