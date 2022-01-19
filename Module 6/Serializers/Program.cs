


using System.Runtime.Serialization.Formatters.Binary;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Serializers;

Serialize();
Deserialize();

void Serialize()
{
    Person p = new Person {FirstName = "Kees", LastName="de Vries", Age=42};

    //BinaryFormatter fmt = new BinaryFormatter();
    //var stream = File.Create(@"D:\person.bin");
    //var stream = File.Create(@"D:\person.xml");
    //XmlSerializer fmt = new XmlSerializer(typeof(Person));

    var stream = File.Create(@"D:\person.json");
    var sw = new StreamWriter(stream);
    JsonSerializer fmt = new JsonSerializer();
    fmt.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();

    fmt.Serialize(sw, p);
    sw.Close();

    var person = JsonConvert.SerializeObject(p);
    System.Console.WriteLine(person);
    
    Person? p2 = JsonConvert.DeserializeObject<Person>(person);
    System.Console.WriteLine(p2?.LastName);

}

void Deserialize()
{
    // BinaryFormatter fmt = new BinaryFormatter();
    // var stream = File.OpenRead(@"D:\person.bin");
    // var stream = File.OpenRead(@"D:\person.xml");
    // XmlSerializer fmt = new XmlSerializer(typeof(Person));
    // XmlReader rdrMain = XmlReader.Create(stream);
    // rdrMain.ReadToFollowing("person");
    // XmlReader rdr = rdrMain.ReadSubtree();

    var stream = File.OpenRead(@"D:\person.json");
    TextReader rdr = new StreamReader(stream);
    JsonSerializer fmt = new JsonSerializer();
    fmt.ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver();

    Person? p = fmt.Deserialize(rdr, typeof(Person)) as Person;
    System.Console.WriteLine(p!.FirstName);
    System.Console.WriteLine(p!.LastName);
    System.Console.WriteLine(p!.Age);

}

