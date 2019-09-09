using System;

namespace DotNetTutorial
{
    class Arrays
    {
        public void call()
        {
            var numbers = new [] { 3, 7, 9, 2, 14, 6 };
            Console.WriteLine("Lengt: " + numbers.Length);

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            Array.Clear(numbers, 0, 2);

            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }

            var another = new int[3];
            Console.WriteLine("Coppy");
            Array.Copy(numbers, another, 3);
            foreach (var n in another)
            {
                Console.WriteLine("Another: " + n);
            }

            Console.WriteLine("Effect of sorting");
            Array.Sort(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine("Sorted: " + n);
            }

            Console.WriteLine("Reverse");
            Array.Reverse(numbers);
            foreach (var n in numbers)
            {
                Console.WriteLine("Revers: " + n);
            }
        }
    }
}
