using Archipelago.Core;
using Archipelago.Core.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archipelago.PCSX2
{
    public class PCSX2Client : IGameClient
    {
        public bool IsConnected { get; set; }
        public int ProcId { get; set; }
        public string ProcessName { get; set; }
        public PCSX2Client()
        {

            ProcessName = "pcsx2";
            ProcId = Memory.PCSX2_PROCESSID;
        }
        public bool Connect()
        {
            Console.WriteLine($"Connecting to {ProcessName}");
            if (ProcId == 0)
            {
                Console.WriteLine($"{ProcessName} not found.");
                Console.WriteLine("Press any key to exit.");
                Console.Read();
                System.Environment.Exit(0);
                return false;
            }
            return true;
        }
    }
}
