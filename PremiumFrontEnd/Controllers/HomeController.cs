using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PremiumFrontEnd.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string gender, int age)
        {
            float premium = 0;

            if (gender == "female")
            {
                if ((age >= 18) && (age <= 30))
                    premium = 5.0f;
                else
                    if (age >= 31)
                    premium = 3.50f;
                else
                    premium = 0.0f;
            }

            else if (gender == "male")
            {
                if ((age >= 18) && (age <= 35))
                    premium = 6.0f;
                else
                    if (age >= 36)
                    premium = 5.0f;
                else
                    premium = 0.0f;
            }
            else
                premium = 0.0f;

            if (age >= 50)
                premium = premium * 0.5f;
            ViewBag.Result = premium;
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
    }
}