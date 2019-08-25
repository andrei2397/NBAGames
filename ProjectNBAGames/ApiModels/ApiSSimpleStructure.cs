using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNBAGames.ApiModels
{
    public class ApiSSimpleStructure<T>
    {
        public List<T> Data { get; set; }
        public ApiSSimpleStructure()
        {
            Data = new List<T>();
        }

    }
}