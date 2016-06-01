namespace _09.Capitalization
{
    #region

    using System;
    using System.Text;

    #endregion

    class Capitalization
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var sb = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var currentName = input[i];
                for (int j = 0; j < currentName.Length; j++)
                {
                    if (j == 0 || currentName[j - 1].ToString() == " " || currentName[j - 1].ToString() == "'")
                    {
                        sb.Append(char.ToUpper(currentName[j]));
                    }
                    else
                    {
                        sb.Append(currentName[j]);
                    }
                }

                sb.Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}