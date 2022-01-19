using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RssReader
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingWebRequest();
        }

        private static void UsingWebRequest()
        {
            HttpWebRequest request = WebRequest.Create("http://nu.nl/rss") as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream str = response.GetResponseStream();
                WithXmlSerializer(str);
                //WithLinqToXml(str);
                //WithRegularExpressions(str);
            }
        }

        private static void WithRegularExpressions(Stream str)
        {
            StreamReader rdr = new StreamReader(str);
            string data = rdr.ReadToEnd();
            Regex reg = new Regex(@"<item>.*?<title>(?<title>.*?)</title>.*?<description>(?<desc>.*?)</description>.*?<category>(?<cat>.*?)</category>.*?</item>", RegexOptions.None);
            var mc = reg.Matches(data);
            List<Item> items = new List<Item>();
            foreach(Match it in mc)
            {
                items.Add(new Item { 
                Title = it.Groups["title"].Value,
                Description = it.Groups["desc"].Value,
                Category = it.Groups["cat"].Value
                });
            }
            ShowItems(items);
        }

        private static void WithLinqToXml(Stream str)
        {
            XDocument doc = XDocument.Load(str);

            var query = from item in doc.Descendants("item")
                        select new Item
                        {
                            Title = item.Element("title").Value,
                            Description = item.Element("description").Value,
                            Category = item.Element("category").Value,
                        };

            ShowItems(query.ToList());
        }

        private static void WithXmlSerializer(Stream str)
        {
            XmlSerializer serial = new XmlSerializer(typeof(Item));
            XmlReader rdr = XmlReader.Create(str);

            List<Item> items = new List<Item>();
            while(rdr.ReadToFollowing("item"))
            {
                XmlReader sub = rdr.ReadSubtree();
                Item item = serial.Deserialize(sub) as Item;
                if (item != null)
                {
                    items.Add(item);
                }
            }
            ShowItems(items);
        }

        private static void ShowItems(List<Item> items)
        {
            foreach(Item item in items)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(item.Category);
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(item.Title);
                Console.ResetColor();
                Console.WriteLine(item.Description);
                Console.WriteLine("=========================================================");

            }
        }
    }
}
