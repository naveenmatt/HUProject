using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassifiedSite_1._0.Models
{
    public class AdsListModel
    {
        public  List<AdsListItem> AdsList { get; set; }
        
    }

    public class AdsListItem
    {
        public int Id { get; set; }
        public string Adname { get; set; }
        public string Availability { get; set; }
        public string Price { get; set; }
        public string Contact { get; set; }
    }
}