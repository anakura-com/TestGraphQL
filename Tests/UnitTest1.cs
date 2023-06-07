using TestGraphQL;

namespace Tests;

public class Class1Tests
{
    [Fact]
    public void Method1_Succeeds()
    {
        var c = new Class1();

        c.Method1();
    }

    [Fact]
    public void Method2_CollectFilePath_Succeeds()
    {
        const string baseDirectory = @"c:\work";

        var c = new Class1();

        var file = c.Method2("test.txt");

        Assert.Equal($@"{baseDirectory}\test.txt", file.FullName);
    }

    [Fact]
    public void Method2_DangerousFilePath_Succeeds()
    {
        const string baseDirectory = @"c:\work";
        var c = new Class1();

        var file = c.Method2(@"..\Windows\System32\calc.exe");

        Assert.Equal($@"{baseDirectory}\calc.exe", file.FullName);
    }
}