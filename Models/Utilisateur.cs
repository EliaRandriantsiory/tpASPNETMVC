using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todoASPMVC.Models
{
    public class Utilisateur
    {
        private int _idUtilisateur;
        private string _nomUtilisateur;
        private string _motDePasse;

        public string MotDePasse
        {
            get { return _motDePasse; }
            set { _motDePasse = value; }
        }

        public string NomUtilisateur
        {
            get { return _nomUtilisateur; }
            set { _nomUtilisateur = value; }
        }

        public int IdUtilisateur
        {
            get { return _idUtilisateur; }
            set { _idUtilisateur = value; }
        }

        public Utilisateur()
        {
        }

        public Utilisateur(int idUtilisateur, string nomUtilisateur, string motDePasse)
        {
            _idUtilisateur = idUtilisateur;
            _nomUtilisateur = nomUtilisateur;
            _motDePasse = motDePasse;
        }

        public Utilisateur(string nomUtilisateur, string motDePasse)
        {
            _nomUtilisateur = nomUtilisateur;
            _motDePasse = motDePasse;
        }
    }
}