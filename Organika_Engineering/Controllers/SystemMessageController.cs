using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace organika_engineering.Controllers
{
    public class SystemMessageController : Controller
    {
        public ActionResult SystemError()
        {
            return View();
        }
        public PartialViewResult AccessDenied()
        {
            return PartialView();
        }

    }
}
