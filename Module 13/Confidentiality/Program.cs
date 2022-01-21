using System.Security.Cryptography;
using System.Text;

//Asymmetrisch();
Symmetrisch();

void Symmetrisch()
{
    string text = "Hello World";
    byte[] key;
    byte[] iv;

    // Zender
    Aes alg = Aes.Create();
    key = alg.Key;
    iv = alg.IV;

    byte[] crypt;
    using (MemoryStream mem = new MemoryStream())
    {
        using (CryptoStream crypto = new CryptoStream(mem, alg.CreateEncryptor(), CryptoStreamMode.Write))
        using (StreamWriter writer = new StreamWriter(crypto))
        {
            writer.WriteLine(text);
        }
        crypt = mem.ToArray();
    }

    System.Console.WriteLine(Convert.ToBase64String(crypt));



    // Ontvanger
    Aes alg2 = Aes.Create();
    alg2.Key = key;
    alg2.IV = iv;
    using(MemoryStream mem = new MemoryStream(crypt))
    using(CryptoStream crypto = new CryptoStream(mem, alg2.CreateDecryptor(), CryptoStreamMode.Read))
    using(StreamReader rdr = new StreamReader(crypto))
    {
        string line = rdr.ReadToEnd();
        System.Console.WriteLine(line);
    }
    

}

void Asymmetrisch()
{
    string text = "Hello World";

    // Ontvanger
    RSA alg = RSA.Create();
    string publicKey = alg.ToXmlString(false);
    string privKey = alg.ToXmlString(true);


    // Zender
    RSA alg2 = RSA.Create();
    alg2.FromXmlString(publicKey);
    byte[] encData = alg2.Encrypt(Encoding.UTF8.GetBytes(text), RSAEncryptionPadding.Pkcs1);

    System.Console.WriteLine(Convert.ToBase64String(encData));   


    // Ontvanger
    RSA alg3 = RSA.Create();
    alg3.FromXmlString(privKey);
    byte[] data = alg3.Decrypt(encData, RSAEncryptionPadding.Pkcs1);
    System.Console.WriteLine(Encoding.UTF8.GetString(data));


}