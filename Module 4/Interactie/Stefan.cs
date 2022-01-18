namespace Interactie
{
    public class Stefan : Person
    {
        public void Werkt()
        {
            System.Console.WriteLine("Stefan doet iets");
        }

        public override void Works()
        {
            Werkt();
        }
    }
}