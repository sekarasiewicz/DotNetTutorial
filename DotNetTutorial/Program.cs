using System;

namespace DotNetTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculate = new Calculation();

            Console.WriteLine(calculate.Add(100, 100));
            Console.WriteLine("Hello World!");

            var names = new string[3]{ "Setefan", "Józek", "Kazik" };
            Console.WriteLine(string.Join(", ", names));
        }
    }
}
