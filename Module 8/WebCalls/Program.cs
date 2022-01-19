

using System.Net;
using System.Net.Http.Headers;
using WebCalls;

//OldCalling();
//HowItsDone();
//Sweet();

foreach(int x in Yelds())
{
    System.Console.WriteLine(x);
}

IEnumerable<int> Yelds()
{
    yield return 1;
    yield return 2;
    yield return 3;
}

void Sweet()
{
  RssReader rdr = new RssReader();

  foreach(Item it in rdr.GetFeed("https://www.nu.nl/"))
  {
      Console.BackgroundColor = ConsoleColor.Red;
      Console.ForegroundColor = ConsoleColor.Yellow;
      System.Console.WriteLine(it.Category);
      Console.ResetColor();
      Console.ForegroundColor = ConsoleColor.DarkRed;
      System.Console.WriteLine(it.Title);
      Console.ForegroundColor = ConsoleColor.Black;
      System.Console.WriteLine(it.Description);
      Console.ResetColor();
  }
}

void HowItsDone()
{
    HttpClient client = new HttpClient();
    client.BaseAddress = new Uri("https://www.nu.nl/");

    var data = client.GetAsync("rss").Result;
    if (data.IsSuccessStatusCode)
    {
        System.Console.WriteLine(data.Content.Headers.ContentType);
        System.Console.WriteLine(data.Content.Headers.ContentEncoding);
        var txt = data.Content.ReadAsStringAsync().Result;
        System.Console.WriteLine(txt);
    }

    var content = new System.Net.Http.StringContent("Hallo");
    content.Headers.ContentType = new MediaTypeHeaderValue("text/html");
    //client.PostAsync("rss", content);
}

void OldCalling()
{
    HttpWebRequest? request = WebRequest.Create("https://www.nu.nl/rss/binnenland") as HttpWebRequest;
    
    HttpWebResponse? response = request.GetResponse() as HttpWebResponse;

    System.Console.WriteLine(response.StatusCode);

    Stream stream = response.GetResponseStream();
    StreamReader rdr = new StreamReader(stream);
    System.Console.WriteLine(rdr.ReadToEnd());
}
