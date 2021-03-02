using System;
using System.Linq;

namespace SandBox.Basics.StringPlay
{
    public class Anagram
    {
        public bool IsAnagram1(string str1, string str2)
        {
            return string.Concat(str1.OrderBy(c => c))
                .Equals(string.Concat(str2.OrderBy(c => c)));
        }

        public bool IsAnagram2(string str1, string str2)
        {
            if (str1.Length != str2.Length) return false;

            var str1LowerArray = str1.ToLower().ToCharArray();

            var str2LowerArray = str2.ToLower().ToCharArray();

            Array.Sort(str1LowerArray);

            Array.Sort(str2LowerArray);

            str1 = new string(str1LowerArray);

            str2 = new string(str2LowerArray);

            return str1 == str2;
        }
    }
}
