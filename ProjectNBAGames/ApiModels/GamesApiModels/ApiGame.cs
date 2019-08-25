using Newtonsoft.Json;
using System;
using ProjectNBAGames.ApiModels.TeamsApiModels;

namespace ProjectNBAGames.ApiModels.GamesApiModels
{
    public class ApiGame
    {
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "date")]
        public DateTime? Date { get; set; }

        [JsonProperty(PropertyName = "home_team_score")]
        public int? HomeTeamScore { get; set; }

        [JsonProperty(PropertyName = "visitor_team_score")]
        public int? VisitorTeamScore { get; set; }

        [JsonProperty(PropertyName = "season")]
        public int? Season { get; set; }

        [JsonProperty(PropertyName = "home_team")]
        public ApiTeam HomeTeam { get; set; }

        [JsonProperty(PropertyName = "visitor_team")]
        public ApiTeam VisitorTeam { get; set; }
    }
}