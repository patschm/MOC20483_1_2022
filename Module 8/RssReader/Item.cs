using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace RssReader
{
    [XmlRoot("item")]
    public class Item
    {
        [XmlElement("title")]
        public string Title { get; set; }
        [XmlElement("description")]
        public string Description { get; set; }
        [XmlElement("category")]
        public string Category { get; set; }

        //[XmlArray("category")]
        //[XmlArrayItem("category")]
        //public List<string> Categories { get; set; }

    }
}
