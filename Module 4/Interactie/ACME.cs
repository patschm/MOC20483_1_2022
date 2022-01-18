namespace Interactie
{
    public class ACME
    {
        private List<IContract> workers = new List<IContract>();

        public void Hire(IContract emp)
        {
            workers.Add(emp);
        }
        public void StartProduction()
        {
            System.Console.WriteLine("ACME starts producing");
            foreach(IContract worker in workers)
            {
                worker.Produceert();
            }
            
        }
    }
}