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

        public void GetCompetitiveData()
        {

        }
        public Team GetTeam(string team)
        {
            if (team == "Red")
                return Team.Red;
            else
                return Team.Blue;
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
    }
}
