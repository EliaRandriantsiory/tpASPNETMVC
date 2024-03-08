using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace todoASPMVC.Models
{
    public class DbConnectionCU
    {
        public static NpgsqlConnection connectionString = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["TodoDbConnection"].ConnectionString);



        public static void CreationTache(Taches tache)
        {
            var req = $"INSERT INTO public.\"taches\"(nomutilisateur, nomtache, statut)" +
                    $"VALUES('{tache.NomUtilisateur}', '{tache.NomTache}', '{tache.Statut}'); ";
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

        public static void UpdateTache(Taches tache)
        {
            var req = $"UPDATE public.taches SET nomutilisateur = '{tache.NomUtilisateur}', nomtache = '{tache.NomTache}', statut = '{tache.Statut}' WHERE idtache = {tache.IdTache}";

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
