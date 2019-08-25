using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectNBAGames.ViewModels
{
    public class SimpleStructureViewModel<T>
    {
        public List<T> Data { get; set; }

      

        public SimpleStructureViewModel()
        {
            Data = new List<T>();
           
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