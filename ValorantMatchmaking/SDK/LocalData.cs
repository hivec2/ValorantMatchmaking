using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ValorantMatchmaking.SDK
{
    public class LocalData
    {
        private static string _riotClientLockfileLocation { get; set; } = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Riot Games\\Riot Client\\Config\\lockfile";
        private static string _riotClientPlatform { get; set; } = "ew0KCSJwbGF0Zm9ybVR5cGUiOiAiUEMiLA0KCSJwbGF0Zm9ybU9TIjogIldpbmRvd3MiLA0KCSJwbGF0Zm9ybU9TVmVyc2lvbiI6ICIxMC4wLjE5MDQyLjEuMjU2LjY0Yml0IiwNCgkicGxhdGZvcm1DaGlwc2V0IjogIlVua25vd24iDQp9";

        public static int riotClientPort { get; set; } = 0;
        public static string riotClientPassword { get; set; } = string.Empty;
        public static string riotClientAccessToken { get; set; } = string.Empty;
        public static string riotClientEntitlementToken { get; set; } = string.Empty;
        public static void GetLockfileData()
        {
            if (Logger.Instance.verbose)
                Logger.Instance.Info($"Looking for Lockfile. ({_riotClientLockfileLocation})");

            if (!File.Exists(_riotClientLockfileLocation))
            {
                if (Logger.Instance.verbose)
                    Logger.Instance.Info("Lockfile doesnt exist.");
                return;
            }

            if (Logger.Instance.verbose)
                Logger.Instance.Info($"Found Lockfile");


            using (FileStream fileStream = new FileStream(_riotClientLockfileLocation, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                using (StreamReader sr = new StreamReader(fileStream))
                {
                    if (Logger.Instance.verbose)
                        Logger.Instance.Info("Scanning the Lockfile for the Riot Clients local Port and Password");

                    var currentLine = sr.ReadLine();

                    riotClientPort = int.Parse(currentLine.Split(':')[2]);
                    riotClientPassword = currentLine.Split(':')[3];

                    if (riotClientPort != 0 && riotClientPassword != string.Empty)
                    {
                        if (Logger.Instance.verbose)
                            Logger.Instance.Info("Found the Riot Clients local Port and Password");

                        Logger.Instance.Info($"Riot Client Port: {riotClientPort}");
                        Logger.Instance.Info($"Riot Client Password: {riotClientPassword}");
                    }
                }
            }
        }
        public static void GetTokens()
        {
            if (Logger.Instance.verbose)
                Logger.Instance.Info("Attempting to get Local Access & Entitlement tokens");

            if (Logger.Instance.verbose)
                Logger.Instance.Info($"Creating a request to https://127.0.0.1:{riotClientPort}/entitlements/v1/token");

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://127.0.0.1:{riotClientPort}/entitlements/v1/token");
            System.Net.ServicePointManager.ServerCertificateValidationCallback = (senderX, certificate, chain, sslPolicyErrors) => { return true; };
            request.Headers.Add("Authorization", $"Basic {Convert.ToBase64String(Encoding.UTF8.GetBytes($"riot:{riotClientPassword}"))}");
            request.Headers.Add("X-Riot-ClientPlatform", LocalData._riotClientPlatform);
            request.Headers.Add("X-Riot-ClientVersion", $"{GameData.clientVersion}");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        JToken versionJsonData = JObject.FromObject(JsonConvert.DeserializeObject(reader.ReadToEnd()));
                        riotClientAccessToken = (string)versionJsonData["accessToken"];
                        riotClientEntitlementToken = (string)versionJsonData["token"];

                        if (Logger.Instance.verbose)
                            Logger.Instance.Info($"Retrieved Access & Entitilement token");
                    }
                }
            }
           
        }
        public static void VerifyAPICache()
        {
            if (!GameData.apiCacheVerified)
            {
                
            }
        }
    }
}
