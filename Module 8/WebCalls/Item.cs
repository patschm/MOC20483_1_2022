using System.Xml.Serialization;

namespace WebCalls
{
    [XmlRoot("item")]
    public class Item
    {
        [XmlElement("title")]
        public string? Title { get; set; }
        [XmlElement("description")]
        public string? Description { get; set; }
        [XmlElement("category")]
        public string? Category { get; set; }
    }
}