﻿using System;

namespace DotNetTutorial
{
    internal class SoFar
    {
        public void Call()
        {
            Console.Write("What is the speed limit? ");
            //var cos = Console.ReadLine();

            //Console.WriteLine(cos);
            var calculate = new Calculation();

            Console.WriteLine(Calculation.Add(100, 100));

            var a = 10;
            var b = a;

            a++;

            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;

            array2[0] = 0;
            var price = true ? 10f : 20f;
            Console.WriteLine(price);
            Console.WriteLine($"Array1[0]: {array1[0]}, array2[0]: {array2[0]}");

            for (var i = 1; i <= 10; i++)
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

            const string name = "John Smith";

            for (var i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }

            Console.WriteLine(string.IsNullOrWhiteSpace(" "));

            var random = new Random();
            const int passwordLength = 10;


            for (var i = 0; i < passwordLength; i++)
            {
                Console.WriteLine(random.Next(1, 10));
            }

            for (var i = 0; i < passwordLength; i++)
            {
                Console.Write((char) random.Next(97, 122));
            }

            var buffer = new char[passwordLength];

            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char) random.Next(97, 122);
            }

            var password = new string(buffer);
            Console.WriteLine("\nPassword: " + password);
        }
    }
}