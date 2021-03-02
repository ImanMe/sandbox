namespace SandBox.Basics.StringPlay
{
    public class DefangedIpAddress
    {
        public string Defang(string address)
        {
            return address.Replace(".", "[.]");
        }
    }
}
