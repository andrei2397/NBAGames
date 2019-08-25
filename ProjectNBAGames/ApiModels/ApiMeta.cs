using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNBAGames.ApiModels.GamesApiModels
{
    public class ApiMeta
    {
        [JsonProperty(PropertyName = "total_pages")]
        public int? TotalPages { get; set; }

        [JsonProperty(PropertyName = "current_page")]
        public int? CurrentPage { get; set; }

        [JsonProperty(PropertyName = "next_page")]
        public int? NextPage { get; set; }

        [JsonProperty(PropertyName = "per_page")]
        public int? PrevPage { get; set; }

        [JsonProperty(PropertyName = "total_count")]
        public int? TotalCount { get; set; }
    }
}