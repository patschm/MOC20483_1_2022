using MoreInteraction;

WillemKlein wk = new WillemKlein();
SimonVdMeer sm = new SimonVdMeer();

MathDel m1 = sm.Add;
m1 += sm.Subtract;
m1 += sm.Add;
m1 -= sm.Add;

foreach(var item in m1.GetInvocationList())
{
    System.Console.WriteLine(item.Method.Name);
}

wk.Rekendereken(m1, 4, 5);