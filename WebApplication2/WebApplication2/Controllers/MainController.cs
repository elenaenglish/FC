using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
   

    public class MainController : Controller    
    {

        private string navStyleHome = " navbar navbar-expand-lg navbar-dark fixed-top ";
        private string navStyle = " navbar navbar-expand-lg navbar-dark fixed-top navbar-inner-page ";


        public ActionResult Index()
        {
            ViewData["pageTitle"] = "Forum Cooperative";
            ViewData["navStyle"] = navStyleHome;
            return View("Index");
        }
        public ActionResult Platform()
        {
            ViewData["pageTitle"] = "Forum Cooperative : Platform";
            ViewData["navStyle"] = navStyle;
            return View("Platform");
        }
        public ActionResult Partners()
        {
            ViewData["pageTitle"] = "Forum Cooperative : Partners";
            ViewData["navStyle"] = navStyle;
            return View("Partners");
        }
        public ActionResult TokenSale()
        {
            ViewData["pageTitle"] = "Forum Cooperative : Token Sale";
            ViewData["navStyle"] = navStyle;
            return View("TokenSale");
        }
        public ActionResult Community()
        {
            ViewData["pageTitle"] = "Forum Cooperative : Community";
            ViewData["navStyle"] = navStyle;
            return View("Community");
        }
        public ActionResult ForumAcademy()
        {
            ViewData["pageTitle"] = "Forum Cooperative : Forum Academy";
            ViewData["navStyle"] = navStyle;
            return View("ForumAcademy");
        }
        public ActionResult News()
        {
            ViewData["pageTitle"] = "Forum Cooperative : News";
            ViewData["navStyle"] = navStyle;
            return View("News");
        }
    }
   
}