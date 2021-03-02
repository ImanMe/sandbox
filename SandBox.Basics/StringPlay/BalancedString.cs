namespace SandBox.Basics.StringPlay
{
    public class BalancedString
    {
        public int BalancedStringSplit(string s)
        {
            var balance = 0;
            var result = 0;

            foreach (var character in s)
            {
                if (character == 'L') balance++;
                else balance--;
                if (balance == 0) result++;
            }

            return result;
        }
    }
}
