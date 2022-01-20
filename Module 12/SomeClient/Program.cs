
//using SomeLib;

//Person p = new Person { Name = "Kees", Age = 52};
//p.Introduce();


using System.Reflection;

Assembly asm = Assembly.LoadFrom(@"D:\MOC20483_1_2022\Module 12\SomeLib.dll");
System.Console.WriteLine(asm.FullName);


Type? type = asm.GetType("SomeLib.Person");

dynamic p1 = Activator.CreateInstance(type!);
p1.Name1 = "Marieke";
p1.Age = 23;
p1.Introduce();

object? p = Activator.CreateInstance(type!);

PropertyInfo? pName = type!.GetProperty("Name");
pName?.SetValue(p, "Henk");

//PropertyInfo? pAge = type!.GetProperty("Age");
FieldInfo? pAge = type!.GetField("age", BindingFlags.Instance | BindingFlags.NonPublic);
pAge.SetValue(p, -42);

MethodInfo? intro = type!.GetMethod("Introduce");
intro!.Invoke(p, new object[] {});


foreach(TypeInfo tp in asm.GetTypes())
{
    //System.Console.WriteLine(tp.FullName);
    foreach(MemberInfo mi in tp.GetMembers(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
    {
        //System.Console.WriteLine($"\t({mi.MemberType}) {mi.Name}");
    }
}


System.Console.WriteLine("ok");