using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassifiedSite_1._0.DAL
{
    public class DataAccess
    {

        public List<AdListItem> GetAdsList()
        {
            List<AdListItem> adsList = new List<AdListItem>();
            AdListItem listItem = new AdListItem();
            
            //dummy data
            adsList.Add(new AdListItem { Id = 1, Adname = "Super Bike", Availability = "Yes", Price = "$5000.00", Contact = "abxc@gmmail.com" });
            adsList.Add(new AdListItem { Id = 2, Adname = "Fantastic car", Availability = "Yes", Price = "$10000.00", Contact = "abxc@gmmail.com" });
            adsList.Add(new AdListItem { Id = 3, Adname = "Zoom Zoom", Availability = "Yes", Price = "$1200.00", Contact = "abxc@gmmail.com" });
            adsList.Add(new AdListItem { Id = 4, Adname = "Hover board", Availability = "Yes", Price = "$3000.00", Contact = "abxc@gmmail.com" });
            adsList.Add(new AdListItem { Id = 5, Adname = "Drone master", Availability = "Yes", Price = "$4000.00", Contact = "abxc@gmmail.com" });
            adsList.Add(new AdListItem { Id = 6, Adname = "Tech master", Availability = "No", Price = "$1000.00", Contact = "abxc@gmmail.com" });
            adsList.Add(new AdListItem { Id = 7, Adname = "Sword bike", Availability = "Yes", Price = "$4000.00", Contact = "abxc@gmmail.com" });
            adsList.Add(new AdListItem { Id = 8, Adname = "Firey Dragon", Availability = "Yes", Price = "$10000.00", Contact = "abxc@gmmail.com" });
            adsList.Add(new AdListItem { Id = 9, Adname = "Neon ninja", Availability = "Yes", Price = "$20000.00", Contact = "abxc@gmmail.com" });
            adsList.Add(new AdListItem { Id = 10, Adname = "Red mcLaren", Availability = "Yes", Price = "$30000.00", Contact = "abxc@gmmail.com" });

            return adsList;

        }

    }

  
}