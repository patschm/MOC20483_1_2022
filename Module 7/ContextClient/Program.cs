using ContextClient;
using Entities;
using Microsoft.EntityFrameworkCore;
using Bogus;
using Microsoft.Extensions.Logging;

string conStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HobbyDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;MultipleActiveResultSets=true;";

//CreateDataBase();
//CreateData();
LinqTest();

void LinqTest()
{
    DbContextOptionsBuilder bld = new DbContextOptionsBuilder();
    bld.UseSqlServer(conStr);
   // bld.UseLazyLoadingProxies();
    bld.LogTo(m=>System.Console.WriteLine(m), LogLevel.Information);

    HobbyContext context = new HobbyContext(bld.Options);
    

    IQueryable<Entities.Person> query = context.People;
    //query = query.Skip(100).Take(10);
    query = query.OrderBy(p=>p.FirstName);
    query = query.Where(p=>p.LastName.StartsWith("A"));
    var query2 = context.People
        .OrderBy(p=>p.FirstName)
        .Where(p=>p.LastName.StartsWith("A"))
        .Select(p=>new { p.FirstName, LastName = p.LastName });

    var query3 = from p in context.People 
        orderby p.FirstName 
        where p.LastName.StartsWith("A") 
        select new { p.FirstName, LastName = p.LastName };


    foreach(var p in query3.Take(5))
    {
        //System.Console.WriteLine($"{p.FirstName} {p.LastName}");
    }

    var q4 = context.People
         .Include(p=>p.Hobbies)
             .ThenInclude(ph=>ph.Hobby)
        .Take(10);
        //.AsNoTracking();
    foreach(var p in q4)
    {
        System.Console.WriteLine(p.GetType().Name);
        System.Console.WriteLine($"[{p.Id}] {p.FirstName} {p.LastName} ({p.Age})");
        //context.Entry(p).Collection(nameof(p.Hobbies)).Load();
        foreach(var ph in p.Hobbies)
        {
            //context.Entry(ph).Reference(nameof(ph.Hobby)).Load();
            System.Console.WriteLine($"\t{ph?.Hobby?.Description}");
        }
    }

    var p1 = context.People.First();
    p1.LastName = "de Jong";

    var ctEntry = context.Entry(p1);
    System.Console.WriteLine(ctEntry.State);
    System.Console.WriteLine(ctEntry.CurrentValues.GetValue<string>(nameof(p1.LastName)));
    System.Console.WriteLine(ctEntry.OriginalValues.GetValue<string>(nameof(p1.LastName)));

}

void CreateData()
{
    DbContextOptionsBuilder bld = new DbContextOptionsBuilder();
    bld.UseSqlServer(conStr);
    HobbyContext context = new HobbyContext(bld.Options);

    // Hobby h1 = new Hobby { Description = "Zeilen"};
    // Hobby h2 = new Hobby { Description = "Sigarenbandje"};
    // Hobby h3 = new Hobby { Description = "Kapok Plukken"};

    // context.Hobbies.AddRange(h1, h2, h3);
    // context.SaveChanges();

    var hobbies = context.Hobbies.ToList();
    // foreach(var hobby in hobbies)
    // {
    //     System.Console.WriteLine(hobby.Description);
    // }
    var fakes = new Faker<Entities.Person>();
    fakes.RuleFor(p=>p.FirstName, fk=>fk.Name.FirstName());
    fakes.RuleFor(p=>p.LastName, fk=>fk.Name.LastName());
    fakes.RuleFor(p=>p.Age, fk=>fk.Random.Int(0, 123));
    var people = fakes.Generate(1000).ToList();

    var rnd = new Random();

    people.ForEach(p=>{
        var ph = new PersonHobby {
            Person = p,
            Hobby = hobbies[rnd.Next(0, hobbies.Count)]
        };
        p.Hobbies.Add(ph);
    });
        
    context.AddRange(people);
    context.SaveChanges();
    System.Console.WriteLine("Gelukt!!");

}

void CreateDataBase()
{
    DbContextOptionsBuilder bld = new DbContextOptionsBuilder();
    bld.UseSqlServer(conStr);
    HobbyContext context = new HobbyContext(bld.Options);

    context.Database.EnsureCreated();
    System.Console.WriteLine("Gelukt!!");
}
