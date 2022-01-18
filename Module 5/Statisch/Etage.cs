namespace Statisch
{
    public class Etage
    {
        public int Nummer { get; set; }
        // Static deelt members over alle instanties
        // Ook wel class members genoemd.
        public static Lift Elevator { get; } = new Lift();

        public void CallElevator()
        {
            Elevator.Call(Nummer);
        }
        public void ShowStatus()
        {
            System.Console.WriteLine($"Lift staat op de {Elevator.Current}e verdiepong");
        }
    }
}