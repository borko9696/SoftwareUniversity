namespace Problem_4.Text_Filter
{
    using System;

    internal class TextFilter
    {
        private static void Main()
        {
            string[] banList = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            for (int i = 0; i < banList.Length; i++)
            {
                text = text.Replace(banList[i], new string('*', banList[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}