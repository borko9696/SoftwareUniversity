namespace Problem_3.Strawberry
{
    #region

    using System;

    #endregion

    class Strawberry
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int outsideLines = 0;
            int inSideLines = n;
            for (int i = 0; i < (n - 1) / 2; i++)
            {
                Console.WriteLine("{0}\\{1}|{1}/{0}", new string('-', outsideLines), new string('-', inSideLines));
                outsideLines += 2;
                inSideLines -= 2;
            }

            outsideLines = n;
            inSideLines = 1;
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('-', outsideLines), new string('.', inSideLines));
                outsideLines -= 2;
                inSideLines += 4;
            }

            outsideLines = 0;
            inSideLines = (n * 2) + 1;

            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine("{0}#{1}#{0}", new string('-', outsideLines), new string('.', inSideLines));
                outsideLines += 1;
                inSideLines -= 2;
            }
        }
    }
}