using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
using WebData;

namespace Web.Controllers
{
    public class UserHomeController : Controller
    {
        // GET: UserHome
        public ActionResult UserIndex()
        {
            var model = new UserIndexViewModel();
            

            return View(model);
        }

        public ActionResult Search()
        {
            return View();
        }
    }
}