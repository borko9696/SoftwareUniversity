using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Define_a_Class_Person
{
    using System.Reflection;

    class ClassPersonMain
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }
    }

    class Person
    {
       public string name = String.Empty;

        public int age = 0;
    }
}
