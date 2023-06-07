using System.Security.Cryptography;

if (args.Length < 1)
{
    WriteUsage();    
    return;
}

var path = args[0];

if (!File.Exists(path))
{
    Console.WriteLine($"Specified parameter is not a path for private key pem file.");
    WriteUsage();
    return;
}


var pem = await File.ReadAllTextAsync(path);
var rsa = RSA.Create();
rsa.ImportFromPem(pem);


// TODO 



void WriteUsage()
{
    Console.WriteLine("""
        Usage> TestGraphQL <pem file path>
        """);

}