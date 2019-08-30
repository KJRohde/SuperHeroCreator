using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroCreator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "This application allows user to create, edit, or delete information about your favorite super heroes.\nIf there is a new hero you like, please 'Create' a hero.\nIf a hero has new information, please 'Update' that hero.\nIf a hero has fallen from grace or been defeated by a villain, please 'Delete' that hero.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "For more information regarding your heroes, please contact us.";

            return View();
        }
    }
}