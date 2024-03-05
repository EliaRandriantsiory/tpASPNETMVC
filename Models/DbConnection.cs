using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;


namespace todoASPMVC.Models
{
    public class DBConnection
    {
        public static NpgsqlConnection connectionString = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TodoDbConnection"].ConnectionString);


        public static bool AuthentificationUtilisateur(Utilisateur utilisateur)
        {
            var req = $"SELECT * FROM utilisateur WHERE nomutilisateur='{utilisateur.NomUtilisateur}' AND motdepasse='{utilisateur.MotDePasse}';";
            bool hasUtilisateur = false;

            try
            {
                connectionString.Open();

                var cmd = new NpgsqlCommand(req, connectionString);
                var reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    hasUtilisateur = true;

                }
                connectionString.Close();

            }
            catch (Exception e)
            {

                throw e;
            }
            return hasUtilisateur;


        }
        public static void CreationCompte(Utilisateur utilisateur)
        {
            var req = $"INSERT INTO utilisateur(nomutilisateur, motdepasse) VALUES ('{utilisateur.NomUtilisateur}','{utilisateur.MotDePasse}');";

            try
            {
                connectionString.Open();

                var cmd = new NpgsqlCommand(req, connectionString);
                cmd.ExecuteNonQuery();

                connectionString.Close();


            }
            catch (Exception e)
            {
                throw e;
            }


        }
    }
}