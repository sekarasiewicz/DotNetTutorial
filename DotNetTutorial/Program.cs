using System;

namespace DotNetTutorial
{
    partial class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
