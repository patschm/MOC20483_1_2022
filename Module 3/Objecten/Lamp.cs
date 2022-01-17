namespace Objecten
{
    // Dit is de blauwdruk van een lamp
    public class Lamp
    {
        // Eigenschappen. Leggen we vast in fields
        private int lumen = 100;
        //private ConsoleColor color = ConsoleColor.Yellow;
        
        // Properties. Hiermee geef je gecontroleerd toegang tot je fields (Encapsulation)
        public int Lumen 
        {
            get
            {
                return lumen;
            }
            set
            {
                 if(value >= 0 && value < 1000)
            {
                lumen = value ;
            }
            }
        }
        
        // Auto generated property.
       public ConsoleColor Color { get; set; }
        
        // Dit is de archaische manier van Encapsulation (Java, C++)
        public void SetLumen(int lm)
        {
            if(lm >= 0 && lm < 1000)
            {
                lumen = lm;
            }
        }
        public int GetLumen()
        {
            return lumen;
        }

        // Gedrag. Leggen we vast in Methods
        public virtual void Aan()
        {
            Console.BackgroundColor = Color;
            Console.WriteLine($"De lamp is nu aan en brandt met {Lumen} lumen");
            Console.ResetColor();
        }

        // Constructor. Gebruik je om fields een initiele waarde te geven.
        public Lamp(): this(100, ConsoleColor.Yellow)
        {

        }
        public Lamp(int lumen, ConsoleColor color)
        {
            this.Lumen = lumen;
            this.Color = color;
        }
    }
}