using System.Xml;
using System.Xml.Serialization;

namespace WebCalls
{
    public class RssReader
    {
        private XmlSerializer serializer = new XmlSerializer(typeof(Item));
        private HttpClient client = new HttpClient { BaseAddress = new Uri ("http://www.nu.nl/")};

        public IEnumerable<Item> GetFeed(string url)
        {
            client.BaseAddress = new Uri(url);
            var response = client.GetAsync("rss").Result;
            if (response.IsSuccessStatusCode)
            {
                var stream = response.Content.ReadAsStreamAsync().Result;
                var rdr = XmlReader.Create(stream);
                
                while (rdr.ReadToFollowing("item"))
                {
                   yield return ReadItem(rdr.ReadSubtree())!;
                }
            }
        }

        private Item? ReadItem(XmlReader xmlReader)
        {
            try
            {
                return serializer.Deserialize(xmlReader) as Item;
            }
            catch 
            {

            }
            return null;
        }
    }
}