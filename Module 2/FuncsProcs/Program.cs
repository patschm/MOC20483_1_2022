class Program
{
    public static void Main()
    {
        int x = 10;
        int y = 20;
        Swap(ref x, ref y);
        System.Console.WriteLine($"x={x}, y={y}");

        int res;
        Determine(out res);
        System.Console.WriteLine(res);
        // int result = Add(3,4,5,6,7,8,9,10);
        // System.Console.WriteLine(result);
        // MyProc(y:"Morgen", x:result);
        int.TryParse("34", out int res2);
        System.Console.WriteLine(res2);
    }

    static void Determine(out int nr)
    {
        nr = 42;
    }
    static void Swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }

    // Functions
    static int Add(params int[] nrs)
    {
        return nrs.Sum();
    }

    // Procedure
    static void MyProc(int x = 5, string y = "Hey")
    {
        for(int i = 0; i < x; i++)
        {
            Console.WriteLine(y);
        }
    }
    // Overload
    static void MyProc(byte x, string y)
    {
        System.Console.WriteLine(y);
    }
}