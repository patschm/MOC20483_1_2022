namespace SomeLib;

[Obsolete("Niet meer gebruiken", false)]
public class Person
{
    private int age;
    [Age(MaxAge =  150)]
    public int Age
    {
        get { return age; }
        set 
        {
            var custAttr = this.GetType().GetProperty(nameof(Age))
                .GetCustomAttributes(false)
                .FirstOrDefault(at=> at == typeof(AgeAttribute));
            int maxval = 130;
            if (custAttr != null)
            {
                maxval = (custAttr as AgeAttribute).MaxAge;
            }
            if (value >= 0 && value < maxval)
            { 
                age = value; 
            }
        }
    }   
    public string? Name { get; set; }

    public void Introduce()
    {
        System.Console.WriteLine($"Hello, I'm {Name} and {Age} years old");
    }

}
