using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; 
using System.Collections; 

namespace LoassSolu.Ass.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Articles()
        { 
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("user_name", "user_name"); 
            return View();
        }
        public ActionResult Timeline()
        {
            return View();
        }
        public ActionResult About() {
            return View();
        } 
    }
}