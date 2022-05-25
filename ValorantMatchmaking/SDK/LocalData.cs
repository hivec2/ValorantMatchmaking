using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantMatchmaking.SDK
{
    public class LocalData
    {
        private static string riotClientLockfileLocation { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Riot Games\\Riot Client\\Config\\lockfile";

        public static int riotClientPort { get; set; } = 0;
        public static string riotClientPassword { get; set; } = string.Empty;

        public static void GetLockfileData()
        {
            if (!File.Exists(riotClientLockfileLocation))
                return;
          
            using (FileStream fileStream = new FileStream(riotClientLockfileLocation, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fileStream))
                {
                    string currentLine = sr.ReadLine();

                    riotClientPort = int.Parse(currentLine.Split(':')[2]);
                    riotClientPassword = currentLine.Split(':')[3];

                    sr.Dispose();
                }
                fileStream.Dispose();
            }
        }
    }
}
