using ProjectNBAGames.ApiModels.GamesApiModels;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace ProjectNBAGames.ApiModels
{
    public class ApiStructure<T>
    {
        public List<T> Data { get; set; }

        [JsonProperty(PropertyName="meta")]
        public ApiMeta Pagination { get; set; }

        public ApiStructure()
        {
            Data = new List<T>();          
        }

        
    }
}