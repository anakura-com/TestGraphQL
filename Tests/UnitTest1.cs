using TestGraphQL;

namespace Tests;

public class Class1Tests
{
    [Fact]
    public async Task Method1_Succeeds()
    {
        await Class1.Method1Async();
    }

    [Fact]
    public void Method2_CollectFilePath_Succeeds()
    {
        const string baseDirectory = @"c:\work";

        var file = Class1.Method2("test.txt");

        Assert.Equal($@"{baseDirectory}\test.txt", file.FullName);
    }

    [Fact]
    public void Method2_DangerousFilePath_Succeeds()
    {
        const string baseDirectory = @"c:\work";

        var file = Class1.Method2(@"..\Windows\System32\calc.exe");

        Assert.NotEqual($@"{baseDirectory}\calc.exe", file.FullName);
    }
}