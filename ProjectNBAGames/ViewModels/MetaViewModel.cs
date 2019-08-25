using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNBAGames.ViewModels
{
    public class MetaViewModel
    {
        
        public int TotalPages { get; set; }
        public int? CurrentPage { get; set; }
        public int? NextPage { get; set; }
        public int PrevPage { get; set; }
        public int TotalCount { get; set; }
    }
}