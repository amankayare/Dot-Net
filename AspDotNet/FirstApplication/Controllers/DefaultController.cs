using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstApplication.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        //public string Index()
        //{
        //    return "Hello <b>World</b>";
        //}
        public ActionResult Method2()
        {
            return View();
        }
    }
}