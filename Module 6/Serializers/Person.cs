using System.Xml.Serialization;

namespace Serializers
{
    //[Serializable]
    [XmlRoot("person")]
    public class Person
    {
        [XmlElement("first-name")]
        public string FirstName { get; set; }
        [XmlElement("last-name")]
        public string LastName { get; set; }
        [XmlElement("age")]
        public int Age { get; set; }
    }
}