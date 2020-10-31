using System;
using System.Collections.Generic;
using System.Text;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Threading;

namespace SSH
{
    public class Ping
    {
        public static async Task  StartPing(int period, string hostNameOrAddress = "ya.ru")
        {
            var pingSender = new System.Net.NetworkInformation.Ping();
            
            Console.Clear();
            Log.SendMessage($"PING {hostNameOrAddress}");

            int i = 1;
            while (true)
            {
                var reply = await pingSender.SendPingAsync(hostNameOrAddress);
                var t = reply.Status;
                Log.SendMessage($"{reply.Buffer.Length} bytes from {reply.Address}:" +
                                  $" icmp_seq={i} status={reply.Status} time={reply.RoundtripTime}ms");                
                i++;
                if (reply.Status != IPStatus.Success)
                {
                    
                }
                Thread.Sleep(period);                
            }
        }
    }
}
