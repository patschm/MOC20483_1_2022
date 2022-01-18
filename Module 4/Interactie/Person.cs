namespace Interactie
{
    public abstract class Person : IContract
    {
        public void Produceert()
        {
            Works();
        }

        public abstract void Works();
        
    }
}