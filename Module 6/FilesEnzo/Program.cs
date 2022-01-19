using System.IO;
using System.Text;

//WriteToStream();
ReadFromStream();

void WriteToStream()
{
    FileInfo fi = new FileInfo(@"D:\hallo.txt");
    FileStream fs = fi.Create();
    string text = "Hello World ";
    for(int i = 0; i < 1000; i++)
    {
        byte[] buffer = Encoding.UTF8.GetBytes(text + i + "\n");
        fs.Write(buffer, 0, buffer.Length);
    }
    fs.Close();
}

void ReadFromStream()
{
    FileInfo fi = new FileInfo(@"D:\hallo.txt");
    FileStream fs = fi.OpenRead();
    byte[] buffer = new byte[5];
    int nrRead = 0;
    do
    {
        Array.Clear(buffer);
        nrRead = fs.Read(buffer, 0, buffer.Length);
        string data = Encoding.UTF8.GetString(buffer);
        System.Console.Write(data);
    }
    while(nrRead > 0);
    

}

