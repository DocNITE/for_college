using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anekdoti.Utils
{
    static class Logs
    {
        public static void Log(string message, ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
        }
        public static void LogInfo(string message)
        {
            Log("[INFO]: ", ConsoleColor.Cyan);
            Log(message + "\n");
        }
        public static void LogSystem(string message)
        {
            Log("[SYSTEM]: ", ConsoleColor.Yellow);
            Log(message + "\n");
        }
        public static void NextLine()
        {
            Log("\n");
        }
    }
}
