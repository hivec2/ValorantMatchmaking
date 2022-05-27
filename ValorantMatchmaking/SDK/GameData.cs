﻿using Newtonsoft.Json;
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

        public static string clientUsername { get; set; } = string.Empty;
        public static string clientTagline { get; set; } = string.Empty;
        public static string clientUserIdentifier { get; set; } = string.Empty;

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
                
            if (!File.Exists(LocalData.valorantAPICachePath + $"VersionData.json"))
                File.WriteAllText(LocalData.valorantAPICachePath + $"VersionData.json", versionData);

            JToken versionJsonData = JObject.FromObject(JsonConvert.DeserializeObject(versionData));
            JToken versionJsonDataCached = JObject.FromObject(JsonConvert.DeserializeObject(File.ReadAllText(LocalData.valorantAPICachePath + $"VersionData.json")));

            gameVersion = (string)versionJsonData["data"]["version"];
            clientVersion = (string)versionJsonData["data"]["riotClientVersion"];
            string gameVersionCached = (string)versionJsonDataCached["data"]["version"];
            string clientVersionCached = (string)versionJsonDataCached["data"]["riotClientVersion"];

            if (gameVersion != gameVersionCached || clientVersion != clientVersionCached)
            {
                apiCacheVerified = false;
                File.WriteAllText(LocalData.valorantAPICachePath + $"VersionData.json", versionData);
            }
            else
                apiCacheVerified = true;

            if (Logger.Instance.verbose)
                Logger.Instance.Info($"Retrieved Versions | Game: {gameVersion} & Riot Client: {clientVersion}");

            client.Dispose();
        }
        public static void GetUserAccountData()
        {
            if (Logger.Instance.verbose)
                Logger.Instance.Info("Attempting to get Local User Information");

            if (Logger.Instance.verbose)
                Logger.Instance.Info("Creating a request to https://auth.riotgames.com/userinfo");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://auth.riotgames.com/userinfo");
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
            request.Headers.Add("Authorization", $"Bearer {LocalData.riotClientAccessToken}");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        //   Console.WriteLine(reader.ReadToEnd());
                        var playerData = JsonConvert.DeserializeObject(reader.ReadToEnd());
                        JToken playerDataObject = JObject.FromObject(playerData);
                        clientUserIdentifier = (string)playerDataObject["sub"];
                        clientUsername = (string)playerDataObject["acct"]["game_name"];
                        clientTagline = (string)playerDataObject["acct"]["tag_line"];

                        if (Logger.Instance.verbose)
                            Logger.Instance.Info("Retrieved all User Information");

                        Console.Title = $"Logged in as {clientUsername}#{clientTagline} -> {clientUserIdentifier}";
                    }
                }
            }
        }
    }
}
