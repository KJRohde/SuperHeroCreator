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
            ViewBag.Message = "This application allows user to add, update, or delete information about heroes in their community.\nIf there is a new hero, please 'Create' a hero.\nIf a hero has new information, please 'Update' that hero.\nIf a hero has left the community or has been defeated by a villain, please 'Delete' that hero.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "For more information regarding our heroes, please contact us.";

            return View();
        }
    }
}