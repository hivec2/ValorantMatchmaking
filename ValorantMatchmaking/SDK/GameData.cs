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
        public static bool apiCacheVerified = false;
        public static string gameVersion { get; set; } = string.Empty;
        public static string clientVersion { get; set; } = string.Empty;

        public static bool IsRunning()
        {
            List<Process> processList = Process.GetProcesses().ToList();
            foreach (Process process in processList)
            {
                if (process.ProcessName.ToLower() == "valorant")
                    return true;
            }
            return false;
        }
        public static void GetVersionData()
        {
            //TODO: Clean up VersionData and VerifyAPICache 
            if (Logger.Instance.verbose)
                Logger.Instance.Info("Getting Valorant and Riot Client version");

            if (gameVersion != string.Empty && clientVersion != string.Empty)
                return;

            if (Logger.Instance.verbose)
                Logger.Instance.Info("Requesting Valorant and Riot version (https://valorant-api.com/v1/version)");


            WebClient client = new WebClient();
            string versionData = client.DownloadString("https://valorant-api.com/v1/version");
                
            if (!File.Exists("ValorantAPICache\\GameVersion.json"))
                File.WriteAllText("ValorantAPICache\\GameVersion.json", versionData);

            JToken versionJsonData = JObject.FromObject(JsonConvert.DeserializeObject(versionData));
            JToken versionJsonDataCached = JObject.FromObject(JsonConvert.DeserializeObject(File.ReadAllText("ValorantAPICache\\GameVersion.json")));

            gameVersion = (string)versionJsonData["data"]["version"];
            clientVersion = (string)versionJsonData["data"]["riotClientVersion"];
            string gameVersionCached = (string)versionJsonDataCached["data"]["version"];
            string clientVersionCached = (string)versionJsonDataCached["data"]["riotClientVersion"];

            if (gameVersion != gameVersionCached || clientVersion != clientVersionCached)
                apiCacheVerified = false;
            else
                apiCacheVerified = true;

            if (Logger.Instance.verbose)
                Logger.Instance.Info($"Retrieved Versions | Game: {gameVersion} & Riot Client: {clientVersion}");

            client.Dispose();
        }
    }
}
