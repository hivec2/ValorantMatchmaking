using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorantMatchmaking.SDK
{
    public class PlayerData
    {
        public string username { get; set; } = string.Empty;
        public string userIdentifier { get; set; } = string.Empty;
        public string agentIdentifier { get; set; } = string.Empty;
        public int accountLevel { get; set; } = 0;
        public int accountRankedRating { get; set; } = 0;
        public int accountEloRating { get; set; } = 0;
        public Rank accountRank { get; set; } = Rank.Unranked;
        public Team userTeam { get; set; } = Team.Unknown;

        public PlayerData(dynamic data)
        {
            userIdentifier = (string)data.Subject;
            agentIdentifier = (string)data.CharacterID;
            accountLevel = (int)data.PlayerIdentity.AccountLevel;
            userTeam = GetTeam((string)data.TeamID);
        }

        public Team GetTeam(string team)
        {
            if (team == "Red")
                return Team.Red;
            else
                return Team.Blue;
        }
        public enum Agent
        {
            Unknown,
            Jett,
            Skye,
            Astra,
            Sova,
            Viper,
            Cypher,
            Breach,
            Raze,
            Killjoy,
            Chamber,
            Neon,
            Sage,
            Rena,
            Omen,
            Brimstone,
            KayO,
            Yoru,
            Pheonix,
            Fade
        }
        public enum Rank
        {
            Unranked,
            Unused1,
            Unused2,
            Iron1,
            Iron2,
            Iron3,
            Bronze1,
            Bronze2,
            Bronze3,
            Silver1,
            Silver2,
            Silver3,
            Gold1,
            Gold2,
            Gold3,
            Platinum1,
            Platinum2,
            Platinum3,
            Diamond1,
            Diamond2,
            Diamond3,
            Immortal1,
            Immortal2,
            Immortal3,
            Radiant
        }
        public enum Team
        {
            Unknown,
            Red,
            Blue
        }

        public static string GetUUID(Agent agent)
        {
            switch (agent)
            {
                case Agent.Jett:
                    return "add6443a-41bd-e414-f6ad-e58d267f4e95";
                case Agent.Skye:
                    return "6f2a04ca-43e0-be17-7f36-b3908627744d";
                case Agent.Astra:
                    return "41fb69c1-4189-7b37-f117-bcaf1e96f1bf";
                case Agent.Sova:
                    return "ded3520f-4264-bfed-162d-b080e2abccf9";
                case Agent.Viper:
                    return "707eab51-4836-f488-046a-cda6bf494859";
                case Agent.Cypher:
                    return "117ed9e3-49f3-6512-3ccf-0cada7e3823b";
                case Agent.Breach:
                    return "5f8d3a7f-467b-97f3-062c-13acf203c006";
                case Agent.Raze:
                    return "f94c3b30-42be-e959-889c-5aa313dba261";
                case Agent.Killjoy:
                    return "1e58de9c-4950-5125-93e9-a0aee9f98746";
                case Agent.Chamber:
                    return "22697a3d-45bf-8dd7-4fec-84a9e28c69d7";
                case Agent.Neon:
                    return "bb2a4828-46eb-8cd1-e765-15848195d751";
                case Agent.Sage:
                    return "569fdd95-4d10-43ab-ca70-79becc718b46";
                case Agent.Rena:
                    return "a3bfb853-43b2-7238-a4f1-ad90e9e46bcc";
                case Agent.Omen:
                    return "8e253930-4c05-31dd-1b6c-968525494517";
                case Agent.Brimstone:
                    return "9f0d8ba9-4140-b941-57d3-a7ad57c6b417";
                case Agent.KayO:
                    return "601dbbe7-43ce-be57-2a40-4abd24953621";
                case Agent.Yoru:
                    return "7f94d92c-4234-0a36-9646-3a87eb8b5c89";
                case Agent.Pheonix:
                    return "eb93336a-449b-9c1b-0a54-a891f7921d69";
                case Agent.Fade:
                    return "dade69b4-4f5a-8528-247b-219e5a1facd6";
            }

            return string.Empty;
        }
        public static Agent GetAgent(string uuid)
        {
            switch (uuid)
            {
                case "add6443a-41bd-e414-f6ad-e58d267f4e95":
                    return Agent.Jett;
                case "6f2a04ca-43e0-be17-7f36-b3908627744d":
                    return Agent.Skye;
                case "41fb69c1-4189-7b37-f117-bcaf1e96f1bf":
                    return Agent.Astra;
                case "ded3520f-4264-bfed-162d-b080e2abccf9":
                    return Agent.Sova;
                case "707eab51-4836-f488-046a-cda6bf494859":
                    return Agent.Viper;
                case "117ed9e3-49f3-6512-3ccf-0cada7e3823b":
                    return Agent.Cypher;
                case "5f8d3a7f-467b-97f3-062c-13acf203c006":
                    return Agent.Breach;
                case "f94c3b30-42be-e959-889c-5aa313dba261":
                    return Agent.Raze;
                case "1e58de9c-4950-5125-93e9-a0aee9f98746":
                    return Agent.Killjoy;
                case "22697a3d-45bf-8dd7-4fec-84a9e28c69d7":
                    return Agent.Chamber;
                case "bb2a4828-46eb-8cd1-e765-15848195d751":
                    return Agent.Neon;
                case "569fdd95-4d10-43ab-ca70-79becc718b46":
                    return Agent.Sage;
                case "a3bfb853-43b2-7238-a4f1-ad90e9e46bcc":
                    return Agent.Rena;
                case "8e253930-4c05-31dd-1b6c-968525494517":
                    return Agent.Omen;
                case "9f0d8ba9-4140-b941-57d3-a7ad57c6b417":
                    return Agent.Brimstone;
                case "601dbbe7-43ce-be57-2a40-4abd24953621":
                    return Agent.KayO;
                case "7f94d92c-4234-0a36-9646-3a87eb8b5c89":
                    return Agent.Yoru;
                case "eb93336a-449b-9c1b-0a54-a891f7921d69":
                    return Agent.Pheonix;
                case "dade69b4-4f5a-8528-247b-219e5a1facd6":
                    return Agent.Fade;
            }
            return Agent.Unknown;
        }
    }
}
