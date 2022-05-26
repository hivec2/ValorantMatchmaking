using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantMatchmaking.SDK
{
    public class Logger
    {
        public static Logger Instance { get; set; } = new Logger();
        public bool verbose { get; set; } = true;
        public string logFile { get; set; } = "LoggerData.txt";
        public void Info(string log)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(DateTime.Now);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" - {log}");
        }
        public void Error(string log)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(DateTime.Now);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($" - {log}");

            using (StreamWriter sw = new StreamWriter(Logger.Instance.logFile))
            {
                sw.WriteLine($"[{DateTime.Now}] - {log}");
                sw.Dispose();
            }
        }
    }
}
