using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHubTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["data"] = "misc_song";



            ViewData["test"] = "songhejun";
            return View();

        }

        public ActionResult About()
        {
            string str = "1232";
            Console.WriteLine(str);



            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}