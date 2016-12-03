using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EssentialTools.Models;

namespace EssentialTools.Controllers
{
    public class HomeController : Controller
    {
        private Product[] products = {
          new Product{Name = "Kayak", Category = "Watersports", Price = 275M},
          new Product{Name = "Lifejacket", Category = "Watersports", Price = 48.95M}
                                     };
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
