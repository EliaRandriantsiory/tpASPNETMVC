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
                var currentUser = Session["nomUtilisateur"].ToString();
                List<Taches> listTache = DbConnectionRD.retrouverTaches(currentUser);

                //listTache = listTache.Where(obj => obj.IdTache == 1).ToList();

                return View(listTache);

            }
            else
            {
                return RedirectToRoute("Home");
            }
            //return View(new  List<Taches>());
        }



        [HttpPost]
        public ActionResult ActionPost(Taches taches)
        {
            var type = Request.Form["btnValidate"];
            var nomTache = Request.Form["inputTextnomtache"];
            var idTache = Request.Form["inputTextIdTache"];
            var statusTahe = Request.Form["checkStatusTache1"];

            if (type == "Ajouter tâche")
            {
                var tache = new Taches(Session["nomUtilisateur"].ToString(), nomTache);
                DbConnectionCU.CreationTache(tache);
                return RedirectToRoute("Dashboard");
            }else if (type == "Modifier tâche")
            {
                var tache = new Taches(int.Parse(idTache),Session["nomUtilisateur"].ToString(), nomTache, statusTahe=="true"? true:false);
                DbConnectionCU.UpdateTache(tache);
                return RedirectToRoute("Dashboard");
                //return Content(tache.IdTache.ToString() + (tache.Statut == true ? "true" : "false") ) ;
                //return Content($"{idTache},{type},{nomTache},{statusTahe},{Session["nomUtilisateur"].ToString()}");
                //return RedirectToRoute("Dashboard");
            }else if(type == "Supprimer tâche") {
                DbConnectionRD.SupprimerTache(int.Parse(idTache));
                return RedirectToRoute("Dashboard");
            }

            return RedirectToRoute("Dashboard");
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