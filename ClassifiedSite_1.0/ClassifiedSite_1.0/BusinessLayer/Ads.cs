using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClassifiedSite_1._0.DAL;
using ClassifiedSite_1._0.Models;

namespace ClassifiedSite_1._0.BusinessLayer
{
    public class Ads
    {
        //fetching values from DAL
        public List<AdsListItem> GetAdsList()
        {
            DataAccess dalObj = new DataAccess();
            List<AdsListItem> adsList = new List<AdsListItem>();
            List<AdListItem> list = dalObj.GetAdsList();
            foreach (var item in list)
            {
                adsList.Add(new AdsListItem
                { Id = item.Id, Adname = item.Adname,
                    Availability = item.Availability, Contact = item.Contact, Price = item.Price });
            }

            return adsList;
        }


    }
}