using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ValorantMatchmaking.SDK
{
    public class GameData
    {
        public static string gameVersion { get; set; } = string.Empty;
        public static string clientVersion { get; set; } = string.Empty;

        public static bool IsRunning()
        {
            List<Process> processList = Process.GetProcesses().ToList();
            foreach (Process process in processList)
            {
                if (process.ProcessName.ToLower() == "valorant")
                {
                    return true;
                }
            }
            return false;
        }
        public static void GetVersionData()
        {
            if (gameVersion != string.Empty && clientVersion != string.Empty)
                return;

            WebClient client = new WebClient();
            string versionData = client.DownloadString("https://valorant-api.com/v1/version");

            if (!File.Exists("ValorantAPICache\\GameVersion.json"))
                File.WriteAllText("ValorantAPICache\\GameVersion.json", versionData);
            else
            {

            }
            JToken versionJsonData = JObject.FromObject(JsonConvert.DeserializeObject(versionData));
            gameVersion = (string)versionJsonData["data"]["version"];
            clientVersion = (string)versionJsonData["data"]["riotClientVersion"];
        }
    }
}
