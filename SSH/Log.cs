using System;
using System.Collections.Generic;
using System.Text;

namespace SSH
{
    public class Log
    {
        private delegate void WriteMessage(string msg);
        private static event WriteMessage LogEvent;

        static Log() 
        {
            LogEvent += WriteConsole;
        }

        public static void SendMessage(string message) 
        {
            LogEvent(message);
        }

        private static void WriteConsole(string message) 
        {
            Console.WriteLine(message);
        }

        private static void WriteLog(string message)
        {
            Console.WriteLine();
        }

        private static void WriteFile(string message)
        {
            Console.WriteLine();
        }
    }
}
