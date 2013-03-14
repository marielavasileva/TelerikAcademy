
using System;
using System.Text.RegularExpressions;

class URLPrint
{
    static void Main()
    {
        string urlString = "http://www.pss.bg/vremeto/vremeto.php";
        string protocol = "[^:]*";
        string server = @"/([^/][\w\.]*)";
        string resource = @"\b/[^/][\w.]*.+";
        Match matchProt = Regex.Match(urlString, protocol);
        Match matchServer = Regex.Match(urlString, server);
        Match matchResource = Regex.Match(urlString, resource);
        Console.WriteLine("[protocol] = \"{0}\"", matchProt);
        Console.WriteLine("[server] = \"{0}\"", matchServer.Groups[1]);
        Console.WriteLine("[server] = \"{0}\"", matchResource);
    }
}