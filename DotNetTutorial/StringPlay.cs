using System;

namespace DotNetTutorial
{
    public class StringPlay
    {
        public static void Call()
        {
            const string fullName = "Sebastian Karasiewicz ";

            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("ToUpper: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lasName = fullName.Substring(index + 1);

            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lasName);

            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            var replace = fullName.Replace("Karasiewicz", "Karaś");
            Console.WriteLine("Replace: " + replace);

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            const string str = "25";
            var parsedString = int.Parse(str);
            var convertedToByte = Convert.ToByte(str);
            var convertedString = Convert.ToInt32(str);

            Console.WriteLine("Parsed to String: " + parsedString);
            Console.WriteLine("Converted to Byte: " + convertedToByte);
            Console.WriteLine("Converted to String: " + convertedString);

            const float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));
        }
    }
}