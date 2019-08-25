using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNBAGames.ViewModels
{
    public class StructureViewModel<T>
    {
        public List<T> Data { get; set; }

        public MetaViewModel Pagination { get; set; }

        public StructureViewModel()
        {
            Data = new List<T>();
            Pagination = new MetaViewModel();
        }

        public static StructureViewModel<T> Empty
        {
            get { return new StructureViewModel<T>(); }
        }

        public bool IsEmpty
        {
            get { return Data == null || !Data.Any(); }
        }
    }
}