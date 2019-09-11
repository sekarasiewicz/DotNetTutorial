using System;
using System.Globalization;

namespace DotNetTutorial
{
    internal static class DateAndTime
    {
        public static void Call()
        {
            var dateTime = new DateTime(2019, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToShortDateString());

            Console.WriteLine(now.ToString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));

            // Time Span

            var timeSpan = new TimeSpan(1, 2, 3);
            var timeSpan1 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;

            Console.WriteLine(duration);

            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("TotalMinutes: " + timeSpan.TotalMinutes);

            // Add 

            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString 

            Console.WriteLine("ToString: " + timeSpan);

            // Parse

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
            
            var cos = DateTime.Now;
        }
    }
}
