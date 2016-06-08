namespace _01.Censor_Your_Email_Address
{
    #region

    using System;

    #endregion

    class CensorYourEmailAddress
    {
        static void Main(string[] args)
        {
            var mail = Console.ReadLine().Split('@');
            var username = mail[0];
            var domain = mail[1];

            var text = Console.ReadLine();

            text = text.Replace(username + "@" + domain, new string('*', username.Length) + "@" + domain);

            Console.WriteLine(text);
        }
    }
}