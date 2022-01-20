using System.Collections;
using System.Collections.Concurrent;

public class Program
{
    public static void Main()
    {
        //TestSynchronous();
        //TestAsynchronous();
        //HeelMooi();
        //MoreTaskAsync();
        //OokAardig();
        //Fouten();
        //GaatNieGoed();
        Lampjes();
        Console.WriteLine("En verder.....");
        Console.ReadLine();
    }

    private static void Lampjes()
    {
        List<int> nrs = new List<int> { 1, 2, 3, 4 };
        ConcurrentBag<int> list = new ConcurrentBag<int>(nrs);
        
        AutoResetEvent lampje1 = new AutoResetEvent(false);
        ManualResetEvent lampje2 = new ManualResetEvent(false);

        Task.Run(() => {
            Task.Delay(3000).Wait();
            Console.WriteLine("Taak 0 is klaar");
            lampje2.Set();
        });

        Task.Run(() => {
            Console.WriteLine("Gestart 1");
            lampje2.WaitOne(); 
            lampje2.Reset();
            Console.WriteLine("Einde taak 1");
           
        });
        Task.Run(() => {
            Console.WriteLine("Gestart 2");
            lampje2.WaitOne();
            Console.WriteLine("Einde taak 2");
        });

        WaitHandle.WaitAll(new WaitHandle[] { lampje1, lampje2 });

    }

    static object stokje = new object();
    private static void GaatNieGoed()
    {
        int counter = 0;

        Parallel.For(0, 20, idx => {
            lock (stokje)
            {
                int tmp = counter;
                Task.Delay(2000).Wait();
                counter = ++tmp;
            }
            Console.WriteLine(counter);
        });
        Console.WriteLine("Finish");
    }

    private static async void Fouten()
    {
        try
        {
            await Task.Run(async () =>
            {
                Console.WriteLine("Task start");
                await Task.Delay(2000);
                throw new Exception("Oops");
            });
            //.ContinueWith(pt => {
            //        Console.WriteLine(pt.Exception.InnerException.Message);
            //    });
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void OokAardig()
    {
        CancellationTokenSource nikko = new CancellationTokenSource();
        CancellationToken bommetje = nikko.Token;
        Task.Run(async () =>
        {
            do
            {
                if (bommetje.IsCancellationRequested) return;
                Console.WriteLine("ok");
                await Task.Delay(1000);
            }
            while (true);
        });


        nikko.CancelAfter(4000);

    }

    private static async Task MoreTaskAsync()
    {
        int res = 0;
        int res2 = 0;
        var t1 = LongAddAsync(2, 3).ContinueWith(pt => res = pt.Result);
        Console.WriteLine("Eind T1");
        var t2 = LongAddAsync(3, 4).ContinueWith(pt => res2 = pt.Result);
        Console.WriteLine("Eind T2");
        await Task.WhenAll(t1, t2);
        int total = res + res2;
        Console.WriteLine(total);
    }

    private static async void HeelMooi()
    {
        var t1 = Task.Run(() => LongAdd(3, 4));

        var result = await t1;
        Console.WriteLine(result);
        Console.WriteLine("Na taak 1");
    }

    private static void TestAsynchronous()
    {
        //Task<int> t1 = new Task<int>(() => {
        //    int res = LongAdd(2, 3);
        //    return res;
        //});

        var t1 = Task.Run(() => LongAdd(3, 4));

        t1.ContinueWith(pTask =>
        {
            Console.WriteLine(pTask.Result);
        }).ContinueWith(pTask =>
        {
            Console.WriteLine("Klaar");
        });

        t1.ContinueWith(pt =>
        {
            Console.WriteLine("Parallel task");
        });


        //t1.Start();


    }

    private static void TestSynchronous()
    {
        int res = LongAdd(1, 2);
        Console.WriteLine(res);
    }

    static int LongAdd(int a, int b)
    {
        Task.Delay(5000).Wait();
        return a + b;
    }
    static Task<int> LongAddAsync(int a, int b)
    {
        return Task.Run(() => LongAdd(a, b));
    }
}
