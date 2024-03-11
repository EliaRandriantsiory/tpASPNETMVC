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

        public static List<Taches> retrouverTaches(string nomUtilisateur)
        {
            var req = $"SELECT * FROM public.\"taches\" WHERE nomutilisateur = '{nomUtilisateur}'";
            var taches = new List<Taches>();

            connectionString.Open();

            var cmd = new NpgsqlCommand(req, connectionString);
            var rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                var tache = new Taches(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetBoolean(3));
                taches.Add(tache);
            }
            connectionString.Close();
            //}catch(Exception e)
            //    {
            //    throw e;
            //    }
            return taches;
        }

        public static void SupprimerTache(int idtache)

        {
            var req = $"DELETE FROM public.taches WHERE idtache = {idtache}";

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