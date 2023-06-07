namespace TestGraphQL;
public class Class1
{
    public void Method1()
    {
        // 非推奨の API を使用する
        var client = new System.Net.WebClient();
        var s = client.DownloadString("http://example.com/");

        // アンセーフなメモリの使用で、領域外にアクセスする
        unsafe
        {
            int* p = stackalloc int[1];
            p[1] = 0;
        }
        
    }

    public FileInfo Method2(string relativePath)
    {
        var baseDirectory = @"c:\work";

        // パスの結合を文字列の結合で行う
        var path = baseDirectory + @"\" + relativePath;

        // パラメータ repativePath によっては、
        // baseDirectory と path の間に \..\ が含まれる可能性がある
        // 例えば、relativePath が ..\..\..\..\Windows\System32\calc.exe の場合、
        // path は C:\Windows\System32\calc.exe となる
        // これにより、意図しないファイルを開く可能性がある

        var reuslt = new FileInfo(path);

        return reuslt;        
    }
}