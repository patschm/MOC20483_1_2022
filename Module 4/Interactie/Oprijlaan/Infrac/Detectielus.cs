namespace Infrac;
public class Detectielus
{
    public event DeviceTrigger? Detect;
    public void OnDetect()
    {
        System.Console.WriteLine("De detectielus detecteert iets");
        Detect?.Invoke();
    }
}
