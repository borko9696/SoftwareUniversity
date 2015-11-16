using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSymbols
{
    static void Main()
    {
        string str = Console.ReadLine();
        char[] symbols = str.ToCharArray();
        Array.Sort(symbols);

        int counter = 0;
        for (int i = 0; i < symbols.Length - 1; i++)
        {
            counter++;
            if (symbols[i] != symbols[i + 1])
            {
                Console.WriteLine("{0}: {1} time/s", symbols[i], counter);
                counter = 0;
            }

            if (i == symbols.Length - 2)
            {
                Console.WriteLine("{0}: {1} time/s", symbols[i + 1], ++counter);
            }
        }
    }
}
