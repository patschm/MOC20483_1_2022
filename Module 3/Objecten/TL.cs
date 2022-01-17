namespace Objecten
{
    public class TL : Lamp
    {
        private int startTime = 1;
        public int StartTime
        {
            get { return startTime; }
            set
            {
                if (value >= 0 && value < 1000)
                {
                    startTime = value;
                }
            }
        }
        public override void Aan()
        {
            for(int i = 0; i < 4; i++)
            {
                Console.BackgroundColor = Color;
                System.Console.WriteLine("Knipper");
                Task.Delay(1000*StartTime/3).Wait();
                Console.ResetColor();
                Console.Clear();
            }
            Console.BackgroundColor = Color;
            Console.WriteLine($"De lamp is nu aan en brandt met {Lumen} lumen");
            Console.ResetColor();

        }
    }
}