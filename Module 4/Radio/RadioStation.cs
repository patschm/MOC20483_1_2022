namespace Radio
{

    public delegate void ReceiveDel(string msg);

    public class RadioStation
    {
        //private ReceiveDel? _subscribers;
        public event ReceiveDel? subscribers;
        // {
        //     add
        //     {
        //         _subscribers += value;
        //     }
        //     remove
        //     {
        //         _subscribers -= value;
        //     }
        // }
        public void Broadcast()
        {
            System.Console.WriteLine("De uitzending gaat beginne");
            subscribers?.Invoke("Hallo luisteraars");
        }
    }
}