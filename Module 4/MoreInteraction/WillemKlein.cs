namespace MoreInteraction
{
    public delegate int MathDel(int x, int y);

    public class WillemKlein
    {
        public void Rekendereken(MathDel opdracht, int a, int b)
        {
            System.Console.WriteLine("Willem Klein gaat rekenen");
            int result = 0;

            result = opdracht(a, b);

            System.Console.WriteLine($"Het antwoord is: {result}");
        }
    }
}