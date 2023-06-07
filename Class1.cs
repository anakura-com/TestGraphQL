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
}