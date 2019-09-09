using System;
using System.Collections.Generic;

namespace DotNetTutorial
{
    class Lists
    {
        public void call()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            numbers.AddRange(new int[3] { 5, 6, 7 });

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            Console.WriteLine("Index of: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of: " + numbers.LastIndexOf(1));
            Console.WriteLine("Count: " + numbers.Count);

            numbers.Remove(1);

            for(var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            numbers.Clear();
            Console.WriteLine("Count: " + numbers.Count);
        }
    }
}
