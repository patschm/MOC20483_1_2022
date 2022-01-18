namespace Statisch
{
    public class Lift
    {
        public int Current { get; private set; }

        internal void Call(int nummer)
        {
            System.Console.WriteLine($"De lift op weg naar {nummer}");
            Current = nummer;
        }
    }
}