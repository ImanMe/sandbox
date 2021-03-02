using System;
using SandBox.Basics.StringPlay;

namespace SandBox.Basics
{
    internal class Program
    {
        private static void Main()
        {
            // ReverseThings();
            // Anagram();

            var x = new EqualArrays();

            var word1 = new[] {"a", "cb"};
            var word2 = new[] { "ab", "c" };
            var y = x.ArrayStringsAreEqual(word1, word2);
            Console.WriteLine(y);
        }

        private static void ReverseThings()
        {
            Console.WriteLine("Reverse Things");

            var sut = new ReverseThings();

            Console.WriteLine(sut.ReverseString1("iman"));
            Console.WriteLine(sut.ReverseString2("iman"));
            Console.WriteLine(sut.ReverseString3("iman"));
            Console.WriteLine(sut.ReverseString4("iman"));
            Console.WriteLine(sut.ReverseInteger1(123));
            Console.WriteLine(sut.ReverseInteger1(-123));
        }

        private static void Anagram()
        {
            Console.WriteLine("Anagram");

            var sut = new Anagram();

            Console.WriteLine(sut.IsAnagram1("iman", "nami"));
            Console.WriteLine(sut.IsAnagram1("iman","manw"));

            Console.WriteLine(sut.IsAnagram2("iman", "nami"));
            Console.WriteLine(sut.IsAnagram2("iman", "manw"));
        }
    }
}
