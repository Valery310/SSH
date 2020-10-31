using System;

namespace SSH
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
            Console.ReadKey();
        }

        public static async void Start() 
        {
            await Ping.StartPing(3000, "192.168.0.99");
        }
    }
}
