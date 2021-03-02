using System.Linq;
using System.Text;

namespace SandBox.Basics.StringPlay
{
    public class EqualArrays
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            var allOfWord1 = "";
            var allOfWord2 = "";

            foreach (var str in word1)
            {
                allOfWord1 += str;
            }

            foreach (var str in word2)
            {
                allOfWord2 += str;
            }

            return allOfWord1 == allOfWord2;
        }
    }
}
