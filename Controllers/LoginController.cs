﻿using System;
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
            return View();
        }
        [HttpPost]
        public ActionResult Login(Utilisateur utilisateur)
        {
            utilisateur.MotDePasse = Request.Form["motDePasseLogin"];
            if (DBConnection.AuthentificationUtilisateur(utilisateur))
            {
                Session["nomUtilisateur"] = utilisateur.NomUtilisateur;
                return RedirectToRoute("Dashboard");
                //return Content(utilisateur.NomUtilisateur);
            }
            else
            {
                return View();
            }

            //return Content($"utilisateur:{utilisateur.NomUtilisateur}\nmot de passe{utilisateur.MotDePasse}");

        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToRoute("Home");
        }

        [HttpGet]
        public ActionResult CreationCompte() 
        {
            return View();
        }
        [HttpPost]        
        
        public ActionResult CreationCompte(Utilisateur utilisateur)
        {


            //return Content(utilisateur.NomUtilisateur);
            if (utilisateur.NomUtilisateur != null)
            {
                if (Request.Form["motDePasseLogin"] == Request.Form["repmotDePasseLogin"])
                {
                    utilisateur.MotDePasse = Request.Form["motDePasseLogin"];
                    DBConnection.CreationCompte(utilisateur);
                    return RedirectToAction("Login/Login");
                }
                else
                {
                    return View();
                }
                    
                //return RedirectToRoute("Dashboard");
                //return Content($"inscription '{utilisateur.NomUtilisateur}', mot de passe '{utilisateur.MotDePasse}' réussi");
            }
            else
            {
                return View();
            }
        }
    }
}