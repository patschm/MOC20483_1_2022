using System.Linq;
using Statisch;

Etage[] flat = new Etage[30];
for(int i = 0; i < flat.Length; i++)
{
    flat[i] = new Etage {Nummer = i};
}


flat[27].CallElevator();

foreach(Etage et in flat)
{
   // et.ShowStatus();
}


Point a = new Point {X=10, Y=20};
Point b = new Point {X=100, Y=200};

Point c = a + b;
System.Console.WriteLine(a != b);
System.Console.WriteLine(c);

System.Console.WriteLine(a);
DoeIets(a);
System.Console.WriteLine(a);

int ax = 10;
object xx = ax; // Boxing
int yx = (int)xx;


void DoeIets(Point aa)
{
    aa.X = 1000;
    aa.Y = 2000;
}