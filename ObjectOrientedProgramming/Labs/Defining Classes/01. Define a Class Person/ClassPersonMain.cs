namespace _01.Define_a_Class_Person
{
    #region

    using System;
    using System.Reflection;

    #endregion

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
        public int age = 0;

        public string name = string.Empty;
    }
}