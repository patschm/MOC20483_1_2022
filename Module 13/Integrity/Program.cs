using System.Security.Cryptography;
using System.Text;

//SimpleHashing();
//SymmetricHashing();
Asymmetrisch();

void SimpleHashing()
{
    string text = "Hello World";

    SHA1 alg = SHA1.Create();

    byte[] hash = alg.ComputeHash(Encoding.UTF8.GetBytes(text));
    System.Console.WriteLine(Convert.ToBase64String(hash));


    text += ".";
    SHA1 alg2 = SHA1.Create();

    byte[] hash2 = alg2.ComputeHash(Encoding.UTF8.GetBytes(text));
    System.Console.WriteLine(Convert.ToBase64String(hash2));
}

void SymmetricHashing()
{
    string text = "Hello World";
    byte[] key;

    // Zender
    HMACSHA512 alg = new HMACSHA512();
    key = alg.Key;
    byte[] hash = alg.ComputeHash(Encoding.UTF8.GetBytes(text));
    System.Console.WriteLine(Convert.ToBase64String(hash));

    //text += "."; // ED

    // Ontvanger
    HMACSHA512 alg2 = new HMACSHA512();
    alg2.Key = key;
    byte[] hash2 = alg2.ComputeHash(Encoding.UTF8.GetBytes(text));
    System.Console.WriteLine(Convert.ToBase64String(hash2));
}

void Asymmetrisch()
{
    string text = "Hello World";
    string publicKey;

    DSA dsa = DSA.Create();
    publicKey = dsa.ToXmlString(false);
    byte[] signature = dsa.SignData(Encoding.UTF8.GetBytes(text), HashAlgorithmName.SHA1);

    System.Console.WriteLine(publicKey);
    text += ".";

    // Ontvanger
    DSA dsa2 = DSA.Create();
    dsa2.FromXmlString(publicKey);
    bool isOk = dsa2.VerifyData(Encoding.UTF8.GetBytes(text), signature, HashAlgorithmName.SHA1);

    System.Console.WriteLine(isOk ? "Prima": "Gehackt");


}