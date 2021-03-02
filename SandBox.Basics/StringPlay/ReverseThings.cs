using System;
using System.Linq;
using System.Text;

namespace SandBox.Basics.StringPlay
{
    public class ReverseThings
    {
        public string ReverseString1(string str)
        {
            var strBuilder = new StringBuilder();

            for (var i = str.Length-1; i >= 0; i--)
                strBuilder.Append(str[i]);

            return strBuilder.ToString();
        }

        public string ReverseString2(string str)
        {
            var reversedArray = str.Reverse().ToArray();

            var reversedString = new string(reversedArray);

            return reversedString;
        }

        public string ReverseString3(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        public string ReverseString4(string str)
        {
            var reversed = "";

            foreach (var character in str) reversed = character + reversed;

            return reversed;
        }

        public int ReverseInteger1(int number = 0)
        {
            var isNegative = number < 0;

            var reverseNumberAsString =new string(Math.Abs(number).ToString().Reverse().ToArray());

            var reversedNumber = int.Parse(reverseNumberAsString);

            if (isNegative) return (reversedNumber * -1);

            return reversedNumber;
        }
    }
}