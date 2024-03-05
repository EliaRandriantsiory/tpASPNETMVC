using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using todoASPMVC.Models;

namespace todoASPMVC.Controllers
{
    public class TachesController : Controller
    {
        // GET: Taches
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewTaches()
        {
            return View(new  List<Taches>());
        }
    }
}