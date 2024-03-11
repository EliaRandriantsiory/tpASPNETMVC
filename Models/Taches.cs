using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace todoASPMVC.Models
{
    public class Taches
    {
		private int _idTache;
		private string _nomUtilisateur;
		private string _nomTache;
		private bool _statut;

        public Taches()
        {
        }

        public Taches(string nomUtilisateur, string nomTache)
        {
            _nomUtilisateur = nomUtilisateur;
            _nomTache = nomTache;
        }

        public Taches(string nomUtilisateur, string nomTache, bool statut)
        {
            _nomUtilisateur = nomUtilisateur;
            _nomTache = nomTache;
            _statut = statut;
        }

        public Taches(int idTache, string nomUtilisateur, string nomTache, bool statut)
        {
            _idTache = idTache;
            _nomUtilisateur = nomUtilisateur;
            _nomTache = nomTache;
            _statut = statut;
        }

        public bool Statut
		{
			get { return _statut; }
			set { _statut = value; }
		}

		public string NomTache
		{
			get { return _nomTache; }
			set { _nomTache = value; }
		}

		public string NomUtilisateur
		{
			get { return _nomUtilisateur; }
			set { _nomUtilisateur = value; }
		}

		public int IdTache
		{
			get { return _idTache; }
			set { _idTache = value; }
		}

	}
}