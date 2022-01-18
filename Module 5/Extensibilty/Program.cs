using Extensibilty;

string s = "Hallo";
var news = s.SponsoredBy("Sony");
System.Console.WriteLine(news);

string p = "moooooi";
System.Console.WriteLine("Hoii".SponsoredBy("AKAI"));

System.Console.WriteLine(42.SponsoredBy("Kenwood"));

Point p1 = new Point {X = 100, Y = 200};
Point p2 = new Point {X = 100, Y = 200};

System.Console.WriteLine(p1 == p2);
System.Console.WriteLine(p1);

