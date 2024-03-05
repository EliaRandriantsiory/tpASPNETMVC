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
        public ActionResult Login(Utilisateur utilisateur)
        {
            //if (DBConnection.AuthentificationUtilisateur(utilisateur) != null)
            return View();

        }
        public ActionResult CreationCompte(Utilisateur utilisateur)
        {
            if (utilisateur != null)
            {
                DBConnection.CreationCompte(utilisateur);

                return Content($"inscription '{utilisateur.NomUtilisateur}', mot de passe '{utilisateur.MotDePasse}' réussi");
            }
            else
            {
                return Content("error");
            }
        }
    }
}