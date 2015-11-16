using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Phonebook
{
    static void Main()
    {
        List<string> phonebookList = new List<string>();
        List<string> names = new List<string>();
        List<string> numbers = new List<string>();
        
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        phonebookList = Console.ReadLine().Split('-').ToList();
        do
        {
            
            names.Add(phonebookList[0]);
            numbers.Add(phonebookList[1]);
            phoneBook.Add(names[0], numbers[0]);
            phonebookList.Clear();
            names.Clear();
            numbers.Clear();
            phonebookList = Console.ReadLine().Split('-').ToList();

        } while (phonebookList[0]!="search");

            do
            {
	        string input=Console.ReadLine();
            if (phoneBook.ContainsKey(input))
            {
                Console.WriteLine("{0} -> {1}", input, phoneBook[input]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.",input);
            }
           
        } while (true);
            
    }
}
