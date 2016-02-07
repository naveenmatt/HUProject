using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassifiedSite_1._0.BusinessLayer;
using ClassifiedSite_1._0.Models;

namespace ClassifiedSite_1._0.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult PostAd()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AdsList()
        {
            ViewBag.Message = "Ads List";
            Ads busObj = new Ads();
            
            AdsListModel viewModel = new AdsListModel();
            viewModel.AdsList = busObj.GetAdsList();
            return View(viewModel);
        }
        
    }
}