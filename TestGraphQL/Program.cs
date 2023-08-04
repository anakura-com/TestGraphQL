using System.Collections;

Console.WriteLine("Hello, World!");

var a = 10;
var b = 20;

a =+ b;
b =- a;

Console.WriteLine(a);
Console.WriteLine(b);


public class Class01
{
    public void Method01()
    {
        var protocolType = System.Net.SecurityProtocolType.Ssl3;
        Console.WriteLine(protocolType);
    }

    public string Method02(string relativePath)
    {
        var basePath = @"C:\work";
        var path = $@"{basePath}\{relativePath}";

        var result = File.ReadAllText(path);

        return result;
    }

    public void Method3()
    {
        Hashtable a = new();
        a["key1"] = "value1";
        a[10] = 20;

        int value = (int)a["key1"];

        Console.WriteLine(value);
    }
}
