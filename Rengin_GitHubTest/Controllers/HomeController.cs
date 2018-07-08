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

            //Değişiklikler
            int a = 4;
            return View();
        }
    }
}