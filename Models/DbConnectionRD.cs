using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace todoASPMVC.Models
{
    public class DbConnectionRD
    {

        public static NpgsqlConnection connectionString = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TodoDbConnection"].ConnectionString);

        //public static List<Taches> retrouverTaches(string nomutilisateur)
        //    req = $"SELECT * FROM public.\"Taches\" WHERE nomutilisateur = '{nomutilisateur}'";
        //    taches = new List<Taches>();

        //    connectionString.Open();

        //    var cmd = new NpgsqlCommand(req, connectionString);

        //    connectionString.Close();


    }
}