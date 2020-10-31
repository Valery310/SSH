using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSH
{
    class SSH
    {
        public void Connection() 
        {
            var connectionInfo = new ConnectionInfo("sftp.foo.com",
                                        "guest",
                                        new PasswordAuthenticationMethod("guest", "pwd"));

            using (var client = new SshClient(connectionInfo))
            {             
                client.Connect();
               var result = client.CreateCommand("").Execute();
                result += client.RunCommand("").Result;
            }
        }
    }
}
////https://github.com/sshnet/SSH.NET/