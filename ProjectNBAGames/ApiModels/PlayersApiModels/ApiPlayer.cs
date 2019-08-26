using Newtonsoft.Json;
using System;
using ProjectNBAGames.ApiModels.TeamsApiModels;

namespace ProjectNBAGames.ApiModels.PlayersApiModels
{
    public class ApiPlayer
    {
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        [JsonProperty(PropertyName = "first_name")]
        public string FirstName { get; set; }

        [JsonProperty(PropertyName = "height_feet")]
        public int? HeightFeet { get; set; }

        [JsonProperty(PropertyName = "height_inches")]
        public int? HeightInches { get; set; }

        [JsonProperty(PropertyName = "last_name")]
        public string LastName { get; set; }

        [JsonProperty(PropertyName = "position")]
        public string Position { get; set; }

        [JsonProperty(PropertyName = "team")]
        public ApiTeam Team { get; set; }

        [JsonProperty(PropertyName = "weight_punds")]
        public int WeightPounds { get; set; }
    }
}