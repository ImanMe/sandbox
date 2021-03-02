using System.Text;

namespace SandBox.Basics.StringPlay
{
    public class GoalParser
    {
        public string Interpret1(string command)
        {
            var firstIteration = command.Replace("()", "o");
            return firstIteration.Replace("(al)", "al");
        }

        public string Interpret2(string command)
        {
           var sb = new StringBuilder(command);
           sb.Replace("()", "o");
           sb.Replace("(al)", "al");
           return sb.ToString();
        }
    }
}
