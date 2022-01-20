// Array
using System.Diagnostics;
using System.Text;

int[] array = {1,2,3,4,5,6,7,8,9,10};
Console.WriteLine(array[0]);
Console.WriteLine(array[^1]);
Console.WriteLine(array[2..5][0]);

int[,] matrix = new int[2,3] {{1,2,3},{4,5,6}};
Console.WriteLine(matrix[1,1]);

int[,,] kubus = new int[3,3,3];

int[][] jagged = new int[5][];
jagged[0] = new int[]{1,2,3};
jagged[1] = new int[]{1,2,3, 4, 5};
jagged[2] = new int[]{1};

List<int> list = new List<int>() {1,2,3,4,5};
list.Add(1);
Console.WriteLine(list[0]);

Dictionary<string, int> telefoonboek = new Dictionary<string, int>();
telefoonboek.Add("een", 1);
Console.WriteLine(telefoonboek["een"]);

foreach(int nr in list)
{
    System.Console.WriteLine($"foreach {nr}");
}

//StringBuilder txt = new StringBuilder();
string txt = "";
Stopwatch sw = new Stopwatch();
sw.Start();
for(int i = 0; i < 100000; i++)
{
    //txt.Append(i);
    txt += i;
}
sw.Stop();
System.Console.WriteLine(sw.Elapsed);