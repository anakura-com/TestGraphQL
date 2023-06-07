namespace TestGraphQL;
public static class Class1
{
    private static HttpClient _client = new HttpClient();
    public static async Task<string> Method1Async()
    {
        // 推奨のAPIに置き換える
        var s = await _client.GetStringAsync("http://example.com/");

        // アンセーフなメモリの使用で、領域外にアクセスする
        unsafe
        {
            int* p = stackalloc int[1];
            p[1] = 0;
        }
        
        return s;
    }

    public static FileInfo Method2(string relativePath)
    {
        var pc = Path.PathSeparator;
        var baseDirectory = $"c:{pc}work";

        // パスの結合を文字列の結合で行う
        var path = $"{baseDirectory}{pc}{relativePath}";

        // パラメータ repativePath によっては、
        // baseDirectory と path の間に \..\ が含まれる可能性がある
        // 例えば、relativePath が ..\..\..\..\Windows\System32\calc.exe の場合、
        // path は C:\Windows\System32\calc.exe となる
        // これにより、意図しないファイルを開く可能性がある

        var reuslt = new FileInfo(path);

        return reuslt;        
    }
}