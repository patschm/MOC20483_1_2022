(int Age, string Name) tx = (Age:42, Name:"Jan");

var t2 = DoeIetsTupeligs();

//int leeft;
string naam;
(_, naam) = t2;
System.Console.WriteLine(naam);

DoeIets(tx);

void DoeIets((int Age, string Name) t)
{
    System.Console.WriteLine($"{t.Age}, {t.Name}");
}

(int, string) DoeIetsTupeligs()
{
    return (50, "Kees");
}