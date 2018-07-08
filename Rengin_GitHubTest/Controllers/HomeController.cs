using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rengin_GitHubTest.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            //abc
            //Değişiklikler
            int a = 4;
            string name = "Ergin";
            string name2 = "Ercan";
            decimal a1   =2;
            return View();
        }
    }
}