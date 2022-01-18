namespace Interactie
{
    public class Patrick : Person
    {
        public void Programmeert()
        {
            System.Console.WriteLine("Pruts wat code in elkaar");
        }

        public override void Works()
        {
            Programmeert();
        }
    }
}