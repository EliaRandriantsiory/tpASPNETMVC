using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using todoASPMVC.Models;

namespace todoASPMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            //if (DBConnection.AuthentificationUtilisateur(utilisateur) != null)

            return View();

        }

        [HttpPost]
        public ActionResult Login(Utilisateur utilisateur)
        {
            //if (DBConnection.AuthentificationUtilisateur(utilisateur) != null)
            return Content(utilisateur.NomUtilisateur);
            //return View();

        }

        [HttpGet]
        public ActionResult CreationCompte() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreationCompte(Utilisateur utilisateur)
        {
            return Content(utilisateur.NomUtilisateur);
            //if (utilisateur != null)
            //{
            //    DBConnection.CreationCompte(utilisateur);

            //    return Content($"inscription '{utilisateur.NomUtilisateur}', mot de passe '{utilisateur.MotDePasse}' réussi");
            //}
            //else
            //{
            //    return Content("error");
            //}
        }
    }
}