using System;
using System.Net.NetworkInformation;
using System.Text;

namespace Ping_Tutorial
{
	public class PingService
	{
	
		public string Data { get; set; }
		public byte[] Buffer { get; set; }
		public int Timeout { get; set; }
		public string Address { get; set; }
		public Ping pingSender { get; set; }
		public PingOptions pingOptions { get; set; }
		//this is our constructor
		public PingService()
		{
			Timeout = 120;
			Address = "4.2.2.2";
			Data = "Learn to Code";
			Buffer = Encoding.ASCII.GetBytes(Data);
			pingSender = new Ping();
			pingOptions = new PingOptions();
			pingOptions.DontFragment = true;
		}

		public bool SendPing()
		{
            PingReply reply = pingSender.Send(Address, Timeout, Buffer, pingOptions);

			if(reply.Status == IPStatus.Success)
			{
                Console.WriteLine("Success");
                Console.WriteLine("Roundtrip: {0}", reply.RoundtripTime);
                Console.WriteLine("Time to Live: {0}", reply.Options?.Ttl);
                Console.WriteLine("Buffer: {0}:", reply.Buffer.Length);
				return true;
            }else
			{
				return false;
			}
        }
	}
}

