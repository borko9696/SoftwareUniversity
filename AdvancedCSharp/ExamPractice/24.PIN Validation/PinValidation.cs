namespace _18.PIN_Validation
{
    using System;

    internal class PinValidation
    {
        private static void Main()
        {
            var name = Console.ReadLine();
            var gender = Console.ReadLine();
            var pin = Console.ReadLine();

            ValidName(name);

            if (pin.Length == 10)
            {
                try
                {
                    ValidDate(pin);
                }
                catch (Exception)
                {
                    
                    InvalidData();
                }

                ValidGender(pin, gender);

                ValidCheckSum(pin);

                Console.WriteLine("{{\"name\":\"{0}\",\"gender\":\"{1}\",\"pin\":\"{2}\"}}",name,gender,pin);
            }
            else
            {
                InvalidData();
            }
        }

        private static void ValidCheckSum(string pin)
        {
            int[] multiply = new[]
            {
                2, 4, 8, 5, 10, 9, 7, 3, 6
            };
            var sum = 0;
            for (int i = 0; i < multiply.Length; i++)
            {
                int pinNumber = int.Parse(pin[i].ToString());
                int multi = pinNumber*multiply[i];
                sum += multi;
            }
            var checkNum = int.Parse(pin[9].ToString());
            if (sum%11 != checkNum && checkNum != 0)
            {
                InvalidData();
            }
            else if (sum%11==10 && checkNum != 0)
            {
                InvalidData();
            }
        }

        private static void ValidGender(string pin, string gender)
        {
            var genderIndex = int.Parse(pin.Substring(8, 1));
            if (gender == "male")
            {
                if (genderIndex%2 == 1)
                {
                    InvalidData();
                }
            }
            else
            {
                if (genderIndex%2 == 0)
                {
                    InvalidData();
                }
            }
        }

        private static void ValidDate(string pin)
        {
            var year = int.Parse(pin.Substring(0, 2));
            var month = int.Parse(pin.Substring(2, 2));
            var day = int.Parse(pin.Substring(4, 2));

            if (month >= 21 && month <= 32)
            {
                month -= 20;
                year += 1900;
            }
            else if (month >= 41 && month <= 52)
            {
                month -= 40;
                year += 2000;
            }

            DateTime date = new DateTime(year, month, day);
        }

        private static void ValidName(string name)
        {
            var nameValue = name.Split(' ');
            if (nameValue.Length == 2)
            {
                if (char.IsLower(nameValue[0][0]) || char.IsLower(nameValue[1][0]))
                {
                    InvalidData();
                }
            }
            else
            {
                InvalidData();
            }
        }

        private static void InvalidData()
        {
            Console.WriteLine("<h2>Incorrect data</h2>");
            Environment.Exit(0);
        }
    }
}