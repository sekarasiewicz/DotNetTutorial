using System;
using System.Text;

namespace DotNetTutorial
{
    public static class BuildString
    {
        public static void Call()
        {
            var builder = new StringBuilder("Hello World");
            builder.Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 10));
            
            Console.WriteLine(builder);

            Console.WriteLine("10th char: " + builder[10]);
        }
    }
}