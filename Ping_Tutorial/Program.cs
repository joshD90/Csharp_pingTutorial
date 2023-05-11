using System.Net.NetworkInformation;
using System.Text;
//create our new ping object
//this will ping Googles DNS server address 4.2.2.2
Ping pingSender = new Ping();


PingOptions pingOptions = new PingOptions();

pingOptions.DontFragment = true;

string data = "Learn to Code";
byte[] buffer = Encoding.ASCII.GetBytes(data);
int timeout = 120;
string address = "4.2.2.2";

PingReply reply = pingSender.Send(address,timeout,buffer,pingOptions);

if(reply.Status == IPStatus.Success)
{
    Console.WriteLine("Success");

    Console.WriteLine("Roundtrip: {0}", reply.RoundtripTime);
    Console.WriteLine("Time to Live: {0}", reply.Options?.Ttl);
    Console.WriteLine("Buffer: {0}:", reply.Buffer.Length);
    
}
else
{
    Console.WriteLine("Unsuccessful");
}

Console.WriteLine("Response: {0}", reply?.Status.ToString());



