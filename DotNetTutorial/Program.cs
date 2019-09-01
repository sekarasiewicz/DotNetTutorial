using System;

namespace DotNetTutorial
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the speed limit? ");
            var cos = Console.ReadLine();

            Console.WriteLine(cos);
            var calculate = new Calculation();

            Console.WriteLine(calculate.Add(100, 100));

            var a = 10;
            var b = a;

            a++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;

            array2[0] = 0;
            float price = true ? 10f : 20f;
            Console.WriteLine(price);
            Console.WriteLine(string.Format("Array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            for (var i=1; i<=10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("i: {0}", i);
                }
            }

            for (var i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("i: {0}", i);
                }
            }

            var name = "John Smith";

            for (var i=0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach(var character in name)
            {
                Console.WriteLine(character);
            }
        }
    }
}
