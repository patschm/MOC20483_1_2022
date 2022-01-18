namespace Radio
{
    public class OntvangstMethodes
    {
        public static void ViaMail(string msg)
        {
            System.Console.WriteLine($"Via mail: {msg}");
        }
        public static void ViaKabel(string msg)
        {
            System.Console.WriteLine($"Via kabel: {msg}");
        }
        public static void ViaEther(string msg)
        {
            System.Console.WriteLine($"Via ether: {msg}");
        }
        public static void ViaTamtam(string msg)
        {
            System.Console.WriteLine($"Via tamtam: {msg}");
        }
    }
}