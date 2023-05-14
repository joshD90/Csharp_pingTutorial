using System.Net.NetworkInformation;
using System.Text;
using Ping_Tutorial;
//now we can use a class to carry out all this
PingService pingService = new PingService();
bool response = pingService.SendPing();
Console.WriteLine(response);





