using System.Diagnostics;

class Program
{
    public static void Main()
    {
        int a = AskNumber("Geeft getal a: ");
        System.Console.WriteLine($"Het getal is {a}");
    }
   
    static int AskNumber(string label)
    {
        do
        {
            Console.Write(label);
            string? sNr = Console.ReadLine();
            try
            {
                int nr = int.Parse(sNr!);
                return nr;
            }
            catch (FormatException fe)
            {
                Debug.WriteLine(fe);
                Console.WriteLine("Dit is geen geldig getal");
            }
            catch(OverflowException oe)
            {
                Debug.WriteLine(oe);
                System.Console.WriteLine($"Getal moet tussen {int.MinValue} en {int.MaxValue} liggen");
            }
            catch(Exception e)
            {
                Debug.WriteLine(e);
                System.Console.WriteLine("Onbekende fout :(");
            }
            finally
            {
                System.Console.WriteLine("he he, eindelijk goed");
            }
        }
        while(true);
    }
}
