namespace EvolutieTheorieDerDelegates
{
    public delegate int MathDel(int a, int b);

    class Program
    {
        static void Main()
        {
            // dotnet 1.0/1.1 (2002)
            MathDel m1 = new MathDel(Add);
            int result = m1(1,2);

            // dotnet 2.0 (2005)
            MathDel m2 = Add;
            result = m2(2,3);

            int c = 10;
            MathDel m3 = delegate(int a, int b)
            {
                return a + b;
            };
            result = m3(3,4);

            // dotnet 3.0/3.5 (2007)
            MathDel m4 = (a, b) => a + b;           
            result = m4(4, 5);

            // Functions
            Func<int, int, int> m5 = IntAdd;
            result = m5(5,6);

            // Procedures
            Action<string> a1 = Console.WriteLine;

            a1(result.ToString());


            System.Console.WriteLine(result);

            // Omstreeks 2018
            int IntAdd(int a, int b)
            {
                return a + b;
            }
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
