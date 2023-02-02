/* 
 *  Name:           Echo Tool
 *  
 *  Description:    Application provides functionality of the echo server and client.
 *                  Designed according to RFC 862 http://www.ietf.org/rfc/rfc0862.txt?number=862
 *                  
 *  Author:         Pavel Bansky
 *  Contact:        pavel@bansky.net
 *  Website:        http://bansky.net/echotool
 * 
 */

namespace EchoTool
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length<1)
            {
                args=new string[1] { " /p tcp /s 502" };
            }

            var echoWorker = new EchoToolWorker(args);
            echoWorker.Run();
        }
    }
}
