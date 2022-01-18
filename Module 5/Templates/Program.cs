
using Templates;

class Program
{
    public static void Main()
    {
        string? s = null;
        System.Console.WriteLine(s!.Length);

        Point<long> p = new Point<long> { X= 10, Y = 20};
        System.Console.WriteLine(p);

        decimal a = 10M;
        decimal b = 20M;

        System.Console.WriteLine($"a = {a}, b = {b}");
        Swap(ref a, ref b);
        System.Console.WriteLine($"a = {a}, b = {b}");
    }

    static void Swap<T>(ref T a, ref T b)
    {
        T tmp = a;
        a = b;
        b = tmp;
    }

    // static void Swap(ref double a, ref double b)
    // {
    //     double tmp = a;
    //     a = b;
    //     b = tmp;
    // }
    // static void Swap(ref float a, ref float b)
    // {
    //     float tmp = a;
    //     a = b;
    //     b = tmp;
    // }
    // static void Swap(ref long a, ref long b)
    // {
    //     long tmp = a;
    //     a = b;
    //     b = tmp;
    // }
    // static void Swap(ref int a, ref int b)
    // {
    //     int tmp = a;
    //     a = b;
    //     b = tmp;
    // }
}
