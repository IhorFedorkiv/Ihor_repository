using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using organika_engineering.Models;
using organika_engineering.Controllers;
using System.Data;
using System.Net;
using System.Net.Mail;

namespace organika_engineering.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Test()
        {
            return View();
        }
    }
}

