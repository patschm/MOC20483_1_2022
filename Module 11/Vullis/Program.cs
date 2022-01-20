using System;
using System.Collections.Generic;
using System.Text;
using Vullis;

class Program
{
    static UnmanagedRes res1 = new UnmanagedRes();
    static UnmanagedRes res2 = new UnmanagedRes();

    public static void Main()
    {
        List < byte[]> lst = new List<byte[]>();
        Action a = () =>
        {
            var data = new byte[1000000];
            
            // Memory Leak
           // lst.Add(data);
        };
        
        do
        {
            a();
        }
        while (true);

        try
        {
            res1.Open();
        }
        finally
        {
            res1.Dispose();
            res1 = null;
        }

        //GC.Collect();
        //GC.WaitForPendingFinalizers();

        using (var res3 = new UnmanagedRes())
        {
            res3.Open();
        }


        using (res2)
        {
            res2.Open();
        }

        res2 = null;
        System.Console.WriteLine("Press Enter to quit");
        GC.Collect();
        Console.ReadLine();
    }
}
