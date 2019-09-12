using System;
using System.Collections.Generic;

namespace DotNetTutorial
{
    public static class StringPlay2
    {
        public static void Call()
        {
            const string sentence = "This is going to be really really really really really really long text.";
            const int maxLength = 20;

            if (sentence.Length < maxLength)
            {
                Console.WriteLine(sentence);
            }
            else
            {
                var words = sentence.Split(' ');
                var totalCharacters = 0;
                var summaryWords = new List<string>();

                foreach (var word in words)
                {
                    totalCharacters += word.Length + 1;
                    if (totalCharacters > maxLength) break;

                    summaryWords.Add(word);
                }

                Console.WriteLine(string.Join(' ', summaryWords) + "...");
            }
        }
    }
}