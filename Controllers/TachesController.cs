using Microsoft.Ajax.Utilities;
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
        
        [HttpGet]
        public ActionResult ViewTaches()
        {
            if (Session["nomUtilisateur"] != null)
            {
                var listTache = new List<Taches>();
                var currentUser = Session["nomUtilisateur"].ToString();
                var tache1 = new Taches(1, currentUser, "manger", false);
                var tache2 = new Taches(2, currentUser, "étudier", false);
                listTache.Add(tache1);
                listTache.Add(tache2);
                return View(listTache);

                //return View(new List<Taches>());
            }
            else
            {
                return RedirectToRoute("Home");
            }
            //return View(new  List<Taches>());
        }
    
        
        public ActionResult CreateTache(Taches tache)
        {
            DbConnectionCU.CreationTache(tache);   
            return View(tache);
        }
        public ActionResult UpdateTache(Taches tache)
        {
            DbConnectionCU.UpdateTache(tache);
            return View(tache);
        }
        public ActionResult DeleteTache(Taches tache)
        {
            DbConnectionRD.SupprimerTache(tache.IdTache);
            return View(tache);
        }
    }
}